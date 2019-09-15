using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class FoodOrder
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }


        public int MenuId { get; set; }

        public Menu Menu { get; set; }

        public bool? IsDelete { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}