using ecommerce_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{

    public class TransactionsService : ITransactionsService
    {
        private readonly EcommerceAppContext db = new EcommerceAppContext();
        
        public Transaction Create()
        {
            throw new NotImplementedException();

        }

        public Transaction Delete()
        {
            throw new NotImplementedException();
        }

        public Transaction Get(int Id)
        {
            return db.Transaction.Find(Id);
        }

        public IEnumerable<Transaction> GetAll()
        {
            return db.Transaction.ToList();
        }

        public Transaction Update()
        {
            throw new NotImplementedException();
        }
    }
}
