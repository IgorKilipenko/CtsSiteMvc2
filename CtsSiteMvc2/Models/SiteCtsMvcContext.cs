using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CtsSiteMvc2.Models
{

    /*
    public class SiteCtsMvcContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SiteCtsMvcContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SiteCtsMvcContext>(new CreateDatabaseIfNotExists<SiteCtsMvcContext>());
        }

        public System.Data.Entity.DbSet<CtsSiteMvc2.Models.Menu> Menus { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }
    }
    */
}
