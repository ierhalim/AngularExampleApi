using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiProject.Models.Orm
{
    public class ApiEntities:DbContext
    {
        public ApiEntities()
        {
            Database.Connection.ConnectionString = "server=127.0.0.1;database=AngularSampleDb;uid=sa;pwd=1234567?";
        }

        public DbSet<Product> Product { get; set; }

    }
}