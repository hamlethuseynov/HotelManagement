using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HotelManagement.Models;

namespace HotelManagement.Data
{
    public class HotelContext:DbContext
    {
        public HotelContext() : base("HotelContext")
        {


        }

        

        public DbSet<User> Users { get; set; }

        public DbSet<BedType> bedTypes { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<BookingDetails> BookingDetails { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<FoodCategory> FoodCategories { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<FoodOrder> FoodOrders { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<Room> Rooms { get; set; }

    }
}