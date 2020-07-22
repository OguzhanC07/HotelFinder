using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.DataAccess
{
    class HotelDbContext:DbContext
    {
        private const string ConnectionString = "Server=DESKTOP-FG912SU\\SQLEXPRESS; Database=HotelDb;uid=sa;pwd=1234;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
