using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace TestWebApi.Controllers
{
    [RoutePrefix("api")]
    public class TestController : ApiController
    {
        [HttpPost]
        [Route("test")]
        public async Task<IHttpActionResult> TestMethod()
        {   
            return Ok("Working absolutely fine");
        }        
    }
}
