using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiProject.Models.Orm
{
    public class Product:ModelBase
    {

        public Decimal Price { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
    }
}