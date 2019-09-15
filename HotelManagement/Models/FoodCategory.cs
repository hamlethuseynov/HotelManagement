using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class FoodCategory
    {
        public int Id { get; set; }

        [Required]      
        public string Name { get; set; }

        public List<Food> Foods { get; set; }
    }
}