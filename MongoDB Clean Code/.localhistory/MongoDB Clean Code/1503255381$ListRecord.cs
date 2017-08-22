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
            MainAsync().Wait();
        }
        static async Task MainAsync()
        {

            var client = new MongoClient();

            IMongoDatabase db = client.GetDatabase("deneme");

            var collection = db.GetCollection<BsonDocument>("person");

            using (IAsyncCursor<BsonDocument> cursor = await collection.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {
                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (BsonDocument document in batch)
                    {
                        Console.WriteLine(document);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
