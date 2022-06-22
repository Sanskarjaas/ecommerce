using ecommerce_app.Models;
using ecommerce_app.Services;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "ADMIN")]
    public class UsersController : Controller {

        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        // api/users/
        [HttpGet]
        public IEnumerable<User> Index()
        {
            return _usersService.GetAll();
        }

        // api/users/:id
        [HttpGet("{id:int}")]
        public User Get(int Id)
        {
            return _usersService.Get(Id);
        }
    }
}
