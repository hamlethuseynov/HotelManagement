using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class Food
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string FoodName { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal FoodPrice { get; set; }

        public bool? IsDelete { get; set; }

        [Required]
        public int FoodCategoryId { get; set; }

        public FoodCategory FoodCategory { get; set; }


        public int MenuId { get; set; }

        public Menu Menu { get; set; }
    }
}