using MongoDB.Driver;
using System;
using System.Windows.Forms;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace MongoDB_Clean_Code
{

    public partial class Main : Form
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        public Main()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("deneme");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("person");

            try
            {
                var document = new BsonDocument
            {
              {"firstname", BsonValue.Create(txtName.Text.ToString())},
              {"lastname", new BsonString(txtSurName.Text.ToString())},
              { "subjects", new BsonArray(new[] {"English", "Mathematics", "Physics"}) },
              { "phone", txtPhone.Text.ToString()},
              { "IdPerson", txtIdPerson.Text.ToString()}
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
    }
}
