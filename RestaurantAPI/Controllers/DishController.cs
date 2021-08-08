using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestaurantAPI.Models;
using RestaurantAPI.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {

        private readonly IDishCollection _dishCollection;

        public DishController(IDishCollection dishCollection)
        {
            _dishCollection = dishCollection;
        }

        [HttpGet]
        public JsonResult GetAllDishes()
        {
            return _dishCollection.GetAllDishes();
        }

        [HttpGet("{id}")]
        public JsonResult GetDishById(string id)
        {
            return _dishCollection.GetDishById(id);
        }

        [HttpPost]
        public string CreateDish([FromBody] Dish dish)
        {
            if (String.IsNullOrEmpty(dish.DishName))
            {
                return JsonConvert.SerializeObject("notCreated : Error");
            }

            _dishCollection.InsertDish(dish);

            return JsonConvert.SerializeObject("create : OK");
        }

        [HttpPut("{id}")]
        public string UpdateDish([FromBody] Dish dish, string id)
        {
            if (dish.DishName == String.Empty)
            {
                return JsonConvert.SerializeObject("notUpdated : Error");
            }
            dish.Id = new ObjectId(id);
            _dishCollection.UpdateDish(dish);

            return JsonConvert.SerializeObject("update : OK");
        }

        [HttpDelete("{id}")]
        public string DeleteDish(string id)
        {
            return _dishCollection.DeleteDish(id);
        }
    }
}
