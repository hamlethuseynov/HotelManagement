using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class Roles
    {

        public int Id { get; set; }

        public string Role { get; set; }

        public List<User> Users { get; set; }
    }
}