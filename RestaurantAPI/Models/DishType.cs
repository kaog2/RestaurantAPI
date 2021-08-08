using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class DishType
    {
        public ObjectId Id { get; set; }

        public string DishTypeName { get; set; }

        public string DishTypeCode { get; set; }

        public bool DishTypeActiv { get; set; }
    }
}
