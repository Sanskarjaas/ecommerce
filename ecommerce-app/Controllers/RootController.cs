using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Controllers
{
    [Route("api")]
    public class RootController : Controller
    {
        public String Index()
        {
            return "Hello World";
        }

    }
}
