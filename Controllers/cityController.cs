using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using asp.Models;

namespace asp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cityController : ControllerBase
    {
        public cityController()
        {
        }

        [HttpGet("")]
        public IEnumerable<String> GetTModels()
        {
            return new String[]{"atalant","new york","Chicago"};
        }

    }
}