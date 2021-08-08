using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using RestaurantAPI.Config;
using RestaurantAPI.Models;
using RestaurantAPI.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Services
{
    public class DishCollection : IDishCollection
    {
        //Db Conection
        internal MongoDbConection _mongoDbConection = new MongoDbConection();
        //A Dish Collection (like the Table in SQL)
        private IMongoCollection<Dish> Collection;

        //Construct to create the Conection to the database in collection dish
        public DishCollection()
        {
            Collection = _mongoDbConection.db.GetCollection<Dish>("dish");
        }

        public JsonResult GetAllDishes()
        {
            return new JsonResult(Collection.Find(new BsonDocument()).ToList());
        }

        public string GetDishById(string id)
        {
            return Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).ToList().ToJson();
        }

        public string InsertDish(Dish dish)
        {
            Collection.InsertOne(dish);
            return JsonConvert.SerializeObject("insert : OK");
        }

        public string UpdateDish(Dish dish)
        {
            var filter = Builders<Dish>.Filter.Eq(x => x.Id, dish.Id);
            Collection.ReplaceOne(filter, dish);
            return JsonConvert.SerializeObject("update : OK");
        }

        public string DeleteDish(string id)
        {
            var filter = Builders<Dish>.Filter.Eq(x => x.Id, new ObjectId(id));
            Collection.DeleteOne(filter);
            return JsonConvert.SerializeObject("delete : OK");
        }
    }
}
