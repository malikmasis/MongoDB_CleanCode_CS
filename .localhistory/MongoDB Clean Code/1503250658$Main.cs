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
            MainAsync().Wait();
            Console.ReadLine();
        }
        static async Task MainAsync()
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("deneme");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("person");

            var document = new BsonDocument
            {
              {"firstname", BsonValue.Create("Peter")},
              {"lastname", new BsonString("Mbanugo")},
              { "subjects", new BsonArray(new[] {"English", "Mathematics", "Physics"}) },
              { "class", "JSS 3" },
              { "age", 45}
            };

            await collection.InsertOneAsync(document);
        }
    }
}
