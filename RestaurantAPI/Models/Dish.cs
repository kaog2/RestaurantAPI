using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Dish
    {
        public ObjectId Id { get; set; }

        public int DishId { get; set; }

        public string DishName { get; set; }

        public string DishCode { get; set; }

        public string DishDescription { get; set; }

        public decimal DishPrice { get; set; }

        public bool DishActiv { get; set; }

        public string DishPicturePath { get; set; }

        public decimal DishOrderWaitingTime { get; set; }

        public string DishAvailable { get; set; }

        public ObjectId DishCategoryId { get; set; }

        public ObjectId DishTypeId { get; set; }

    }
}
