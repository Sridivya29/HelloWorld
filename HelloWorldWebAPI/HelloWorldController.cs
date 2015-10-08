using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldWebAPI.Controllers
{
    public class HelloWorldController : ApiController
    {
        // GET api/HelloWorld
        public string Get()
        {
            return "Hello World";
        }
    }
}
