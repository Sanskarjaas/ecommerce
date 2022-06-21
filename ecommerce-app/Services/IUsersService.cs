using ecommerce_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public interface IUsersService: ICrudService<User>
    {
        public User GetUserByEmail(string Email);
    }
}
