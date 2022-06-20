using ecommerce_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public class UsersService : IUsersService
    {
        private readonly EcommerceAppContext db = new EcommerceAppContext();

        public User Get(int Id)
        {
            return db.User.Find(Id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.User.ToList();
        }

        public User Create()
        {
            throw new NotImplementedException();
        }

        public User Delete()
        {
            throw new NotImplementedException();
        }

        public User Update()
        {
            throw new NotImplementedException();
        }
    }
}
