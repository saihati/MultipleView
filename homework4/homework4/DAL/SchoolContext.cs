using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using homework4.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace homework4.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Instructor> Instructors { get; set; }
 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}