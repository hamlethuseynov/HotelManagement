using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class BedType
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public List<Room> Rooms { get; set; }
    }
}