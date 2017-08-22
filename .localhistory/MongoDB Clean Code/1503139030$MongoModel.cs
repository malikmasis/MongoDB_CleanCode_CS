using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDB_Clean_Code
{
    public class MongoModel : IDisposable

    {

        public MongoModel()
        {
            ResetConnection();
        }

        public void ResetConnection()

        {
            this.MongoClient = new MongoClient("mongodb://10.0.0.100:27017/denemeDB");
            this.CurrentDatabase = this.MongoClient.GetDatabase("denemeDB");
        }

        public MongoClient MongoClient { get; private set; }
        public IMongoDatabase CurrentDatabase { get; private set; }
        public void Dispose()

        {
            this.MongoClient = null;
            this.CurrentDatabase = null;
        }

        public IMongoCollection<MyCollection> getMyCollection()
        {
            return this.CurrentDatabase.GetCollection<MyCollection>("MyCollection");
        }

    }
}
