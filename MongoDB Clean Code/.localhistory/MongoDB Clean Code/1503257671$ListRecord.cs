using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDB_Clean_Code
{
    public partial class ListRecord : Form
    {
        public ListRecord()
        {
            InitializeComponent();

            string CONNECTION_STRING = "mongodb://localhost:27017";

            MongoClient client = new MongoClient(CONNECTION_STRING);
#pragma warning disable CS0618 // Type or member is obsolete
            MongoServer server = client.GetServer();
#pragma warning restore CS0618 // Type or member is obsolete

            IEnumerable<string> databases = server.GetDatabaseNames(); // here we can get list of all databases on server
            MongoDatabase db = server.GetDatabase("deneme"); // but we only need one.
            IEnumerable<string> collections = db.GetCollectionNames(); // get the collection we want to execute the query on.
            var collection = db.GetCollection<BsonDocument>("person");




            var jsonQuery = "";//sample json query as text;{ firstname : \"malik\" }
            BsonDocument doc = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(jsonQuery); // creating bson doc out of the query text.
            QueryDocument query = new QueryDocument(doc); // create query doc out of the bson doc.
            var toReturn = collection.Find(query); // execute the query - it's linq, nothing is sent to the server yet.
            List<BsonDocument> result = toReturn.Take(100).ToList(); // now it's here.

            DataTable dt = new DataTable(); // Create empty datatable we will fill with data.

            foreach (BsonDocument obj in toReturn) // Loop thru all Bson documents returned from the query.
            {
                DataRow dr = dt.NewRow(); // Add new row to datatable.
                ExecuteFillDataTable(obj, dt, dr, string.Empty); // Recursuve method to loop thru al results json.
                dt.Rows.Add(dr); // Add the newly created datarow to the table
            }
            grcListRecord.DataSource = dt;

        }

        private void ExecuteFillDataTable(BsonDocument doc, DataTable dt, DataRow dr, string parent)
        {
            // arrays means 1:M relation to parent, meaning we will have to fake multi levels by adding 1 more row foreach item in array.
            // i created the here because i want to add all new array rows after our main row.
            List<KeyValuePair<string, BsonArray>> arrays = new List<KeyValuePair<string, BsonArray>>();

            foreach (string key in doc.Names) // this will loop thru all our json attributes.
            {
                object value = doc[key]; // get the value of the current json attribute.

                string x; // for my specific needs, i need all values to be save in datatable as strings. you can implument to match your needs.

                // if our attribute is BsonDocument, means relation is 1:1. we can add values to current datarow and call the data column "parent.current".
                // we will use this recursive method to run thru all the child document.
                if (value is BsonDocument)
                {
                    string newParent = string.IsNullOrEmpty(parent) ? key : parent + "." + key;
                    ExecuteFillDataTable((BsonDocument)value, dt, dr, newParent);
                }
                // if our attribute is BsonArray, means relation is 1:N. we will need to add new rows, but not now.
                // we will save it in queue for later use.
                else if (value is BsonArray)
                {
                    // Save array to queue for later loop.
                    arrays.Add(new KeyValuePair<string, BsonArray>(key, (BsonArray)value));


                }
                // if our attribute is datatime i needed it in a spesific string format.
                else if (value is BsonTimestamp)
                {
                    x = doc[key].AsBsonTimestamp.ToLocalTime().ToString("s");

                }
                // if our attribute is null, i needed it converted to string.empty.
                else if (value is BsonNull)
                {
                    x = string.Empty;

                }
                else
                {
                    // for all other cases, just .ToString() it.
                    x = value.ToString();

                    // Make sure our datatable already contains column with the right name. if not - add it.
                    string colName = string.IsNullOrEmpty(parent) ? key : parent + "." + key;
                    if (!dt.Columns.Contains(colName))
                        dt.Columns.Add(colName);

                    // Add the value to the datarow in the right column.
                    dr[colName] = value;

                }

            }

            // loop thru all arrays when finish with standart fields.
            foreach (KeyValuePair<string, BsonArray> array in arrays)
            {
                // create column name that contains the parent name + child name.
                string newParent = string.IsNullOrEmpty(parent) ? array.Key : parent + "." + array.Key;

                // save the old - we will need it so we can add it existing values to the new row.
                DataRow drOld = dr;

                // loop thru all the BsonDocuments in the array
                foreach (BsonDocument doc2 in array.Value)
                {
                    // Create new datarow for each item in array.
                    dr = dt.NewRow();
                    dr.ItemArray = drOld.ItemArray; // this will copy all the main row values to the new row - might not be needed for your use.
                    dt.Rows.Add(dr); // the the new row to the datatable
                    ExecuteFillDataTable(doc2, dt, dr, newParent); // fill the new datarow withh all the values for the BsonDocument in the array.
                }

                dr = drOld; // set the main data row back so we can use it values again.
            }
        }
    }
}
