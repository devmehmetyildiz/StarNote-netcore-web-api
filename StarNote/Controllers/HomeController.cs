using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarNote.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [Route("Test")]
        [HttpGet]
        public string Test()
        {           
            return "OK";
        }
        [Route("DBTest")]
        [HttpGet]
        public string DBTest()
        {
            return "OK";
        }

    }
}
