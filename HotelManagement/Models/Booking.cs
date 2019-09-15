using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class Booking
    {

        public int Id { get; set; }

        //public int RoomId { get; set; }

        //public Room Room { get; set; }

       public int UserId { get; set; }

        public User User { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public DateTime StartDate { get; set; }


        public DateTime EndDate { get; set; }


        public List<BookingDetails> BookingDetails { get; set; }


    }
}