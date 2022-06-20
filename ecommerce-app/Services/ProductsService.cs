using ecommerce_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public class ProductsService : IProductsService
    {
        private readonly EcommerceAppContext db = new EcommerceAppContext();

        public Product Create()
        {
            throw new NotImplementedException();
        }

        public Product Delete()
        {
            throw new NotImplementedException();
        }

        public Product Get(int Id)
        {
            return db.Product.Find(Id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Product.ToList();
        }

        public Product Update()
        {
            throw new NotImplementedException();
        }
    }
}
