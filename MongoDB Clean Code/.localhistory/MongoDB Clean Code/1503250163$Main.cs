using MongoDB.Driver;
using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Clean_Code
{

    public partial class Main : Form
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        public Main()
        {
            InitializeComponent();
            _client = new MongoClient();
            _database = _client.GetDatabase("deneme");

            Console.ReadLine();
        }
     
    }
}
