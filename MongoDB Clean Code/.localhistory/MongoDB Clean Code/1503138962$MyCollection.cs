using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDB_Clean_Code
{
    class MyCollection
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
