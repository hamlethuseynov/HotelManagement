using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        public bool? IsDelete { get; set; }

        [Required]
        public int Age { get; set; }


        public int RoleId {get;set;}

        public Roles Roles { get; set; }
        
        public List<Booking> Bookings { get; set; }

        public List<FoodOrder> FoodOrders { get; set; }

    }
}