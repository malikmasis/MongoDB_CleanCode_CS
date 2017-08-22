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
    public partial class Main : Form
    {
        public Main()
        {
            MainAsync().Wait();

            Console.ReadLine();
        }
        static async Task MainAsync()
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);
        }
    }
}
