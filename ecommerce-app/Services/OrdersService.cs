using ecommerce_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public class OrdersService : IOrdersService
    {

        private readonly EcommerceAppContext db = new EcommerceAppContext();
        public OrdersService()
        {

        }
        public Order Create()
        {
            throw new NotImplementedException();
        }

        public Order Delete()
        {
            throw new NotImplementedException();
        }

        public Order Get(int Id)
        {
            return db.Order.Find(Id);
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Order.ToList();
        }

        public Order Update()
        {
            throw new NotImplementedException();
        }
    }
}
