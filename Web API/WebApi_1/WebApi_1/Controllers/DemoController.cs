using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_1.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> continents = new List<string>()
        {
            "Asia",
            "Africa",
            "America",
            "Antartica",
            "Australia",
            "Europe"
        };

        //Get : api/Demo
        public IEnumerable<string> Get()
        {
            return continents;
        }

        public string Get(int Id)
        {
            return continents[Id - 1];
        }

        public IEnumerable<string>Post([FromBody] string c)
        {
            continents.Add(c);
            return continents;
        }

        public IEnumerable<string>Put(int Id, [FromUri] string c)
        {
            continents[Id - 1] = c;
            return continents;
        }

        public IEnumerable<string>Delete(int Id)
        {
            continents.RemoveAt(Id - 1);
            return continents;
        }
    }
}
