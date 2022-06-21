using ecommerce_app.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthenticateService _authenticateService;
        public AuthController(IAuthenticateService authenticateService)
        {

            _authenticateService = authenticateService;

        }

        [HttpGet]
        public IEnumerable<string>Get()
        {
            return new string[] {"value1","value2"};
        }
        [HttpGet("{id}",Name ="Get")]
        public string Get(int id)
        {
            return "value";

        }
        [AllowAnonymous
            ]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] User User)

        {
            var token = _authenticateService.Authenticate(User.Email, User.Password);
            if(token==null)
            {
                return Unauthorized();
            }
            return Ok(token);

        }
    }
}
