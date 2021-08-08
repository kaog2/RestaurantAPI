using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class DishCategory
    {
        public ObjectId Id { get; set; }

        public string DishCategoryName { get; set; }
    }
}
