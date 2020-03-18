using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProsteWebApi.Controllers
{
    public class CzescController : ApiController
    {
        public string Get()
        {
            return "Czesc";
        }
    }
}

