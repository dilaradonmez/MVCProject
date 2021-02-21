using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=NewYms3144ProjectDB;uid=sa;pwd=1234";
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<SubCategory> SubCategories{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //todo: istisnai ilişkilendirmeler burda gerçekleştirilecek.
          
            base.OnModelCreating(modelBuilder);
           
        }

    }
}
