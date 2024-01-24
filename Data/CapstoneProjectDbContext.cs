using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CapstoneProject.Data
{
    public class CapstoneProjectDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CapstoneProjectDbContext() : base("name=CapstoneProjectDbContext")
        {
        }

        public System.Data.Entity.DbSet<CapstoneProject.Models.AdminInfo> AdminInfoes { get; set; }

        public System.Data.Entity.DbSet<CapstoneProject.Models.BlogInfo> BlogInfoes { get; set; }

        public System.Data.Entity.DbSet<CapstoneProject.Models.EmpInfo> EmpInfoes { get; set; }

        public System.Data.Entity.DbSet<CapstoneProject.Models.Login> Logins { get; set; }
    }
}
