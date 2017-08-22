using MongoDB.Driver;
using System;
using System.Windows.Forms;


namespace MongoDB_Clean_Code
{
    protected static IMongoClient _client;
    protected static IMongoDatabase _database;
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            _client = new MongoClient();
            _database = _client.GetDatabase("test");

            Console.ReadLine();
        }
     
    }
}
