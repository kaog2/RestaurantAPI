using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Services.Contracts
{
    public interface IDishCollection
    {
        public string InsertDish(Dish dish);

        public string UpdateDish(Dish dish);

        public string DeleteDish(string id);

        public JsonResult GetAllDishes();

        public string GetDishById(string id);

    }
}
