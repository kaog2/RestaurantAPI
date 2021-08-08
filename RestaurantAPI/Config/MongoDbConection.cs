using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Config
{
    public class MongoDbConection
    {
        public MongoClient client;

        public IMongoDatabase db;

        public MongoDbConection()
        {
            client = new MongoClient("mongodb://127.0.0.1:27017");
            db = client.GetDatabase("RestaurantDB");
        }
    }
}
