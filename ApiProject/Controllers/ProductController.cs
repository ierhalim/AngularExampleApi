using ApiProject.Models.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiProject.Controllers
{
    public class ProductController : BaseController
    {
        [HttpGet]
        public Product Get(int id)
        {
            return Db.Product.Find(id);
        }
        [HttpGet]
        public List<Product> Get()
        {
            return Db.Product.ToList();
        }

        [HttpPost]
        public async Task Post(Product model)
        {
            var product = new Product
            {
                Brand = model.Brand,
                Price = model.Price,
                Name = model.Name,
                Description = model.Description,

            };
            Db.Product.Add(product);
            await Db.SaveChangesAsync();
        }

   

        [HttpPut]
        public async Task Put(int Id, Product model)
        {
            var product = Db.Product.Find(Id);
            product.Brand = model.Brand;
            product.Price = model.Price;
            product.Name = model.Name;
            product.Description = model.Description;
            await Db.SaveChangesAsync();
        }


    }
}
