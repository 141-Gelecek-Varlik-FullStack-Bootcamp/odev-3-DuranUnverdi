using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.Context
{
   public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LI8CF0L\\SQLEXPRESS;database=patikaDb;integrated security=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDto> UserDtos { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
