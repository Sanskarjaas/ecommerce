using ecommerce_app.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        EcommerceAppContext db = new EcommerceAppContext();

        public IEnumerable<User> Index()
        {
            return db.User.ToList();
        }
    }
}
