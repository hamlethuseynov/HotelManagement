using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class Menu
    {
        public int Id { get; set; }


        public int RoomId { get; set; }

        public Room Room { get; set; }
        public List<Food> Food { get; set; }

        public bool? IsDelete { get; set; }

        public List<FoodOrder> FoodOrders { get; set; }
    }
}