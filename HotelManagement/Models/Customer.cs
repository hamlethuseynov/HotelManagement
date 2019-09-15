using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int PassportNo { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal TotalPayment { get; set; }

        public bool? IsDelete { get; set; }


        public List<Booking> Booking { get; set; }

        public List<FoodOrder> FoodOrders { get; set; }

    }
}