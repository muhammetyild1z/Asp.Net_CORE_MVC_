using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFoot.Data.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-AU0NPSR\\SQLEXPRESS; database=DbCoreFood; integrated security=true");
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
