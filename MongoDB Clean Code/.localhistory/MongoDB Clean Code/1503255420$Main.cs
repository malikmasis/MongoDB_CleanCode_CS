using MongoDB.Driver;
using System;
using System.Windows.Forms;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace MongoDB_Clean_Code
{

    public partial class Main : Form
    {
        MongoClient client=null;
        public Main()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var connectionString = "mongodb://localhost:27017";
            client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = client.GetDatabase("deneme");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("person");
            Person person = new Person();
            try
            {
                var document = new BsonDocument
                {
                  {person.firstname, BsonValue.Create(txtName.Text.ToString())},
                  {person.lastname, new BsonString(txtSurName.Text.ToString())},
                  {"subjects", new BsonArray(new[] {"English", "Mathematics", "Physics"}) },
                  {person.phone, txtPhone.Text.ToString()},
                  {person.IdPerson, txtIdPerson.Text.ToString()}
                };

                collection.InsertOneAsync(document);
                MessageBox.Show("Kişi Başarılıyla Kaydedildi");
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        void Clean()
        {
            txtIdPerson.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSurName.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ListRecord listRecord = new ListRecord();
            //listRecord.Show();
        }
    }
}
