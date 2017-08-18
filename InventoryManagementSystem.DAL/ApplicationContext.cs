using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.DAL
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("name=InventoryManagementSystem")
        {
        }

        public DbSet<Contact> Contact { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}