using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace group.Data
{
    public class groupContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public groupContext() : base("name=groupContext")
        {
        }

        public System.Data.Entity.DbSet<group.Models.Member> Members { get; set; }

        public System.Data.Entity.DbSet<group.Models.Membership> Memberships { get; set; }

        public System.Data.Entity.DbSet<group.Models.Class> Classes { get; set; }

        public System.Data.Entity.DbSet<group.Models.User> Users { get; set; }

        //public System.Data.Entity.DbSet<group.Models.Session> Sessions { get; set; }
    }
}
