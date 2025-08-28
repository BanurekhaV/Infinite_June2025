using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_1.Models;

namespace WebApi_1.Controllers
{
    [RoutePrefix("api/User")]
    public class PersonController : ApiController
    {
        List<Person> personlist = new List<Person>()
        {
            new Person{Id=1, Personname= "Yudhishter", PersonJob= "King", Gender="Male"},
            new Person{Id=2, Personname= "Draupadi", PersonJob= "Queen", Gender="Female"},
            new Person{Id=3, Personname= "Bheem", PersonJob= "Defence Minister", Gender="Male"},
            new Person{Id=4, Personname= "Arjun", PersonJob= "Archerer", Gender="Male"},
            new Person{Id=5, Personname= "Nakul", PersonJob= "Operations", Gender="Male"},
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Person> Get()
        {
            return personlist;
        }

        [HttpGet]
        [Route("Bymsg")]
        public HttpResponseMessage GetAllPersons()
        {
            //creating a response  object with both the data and the status code
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);

            ////incase we donot want to send data but only response
            //HttpResponseMessage response = response.Content = new StringContent("Thanks");
            return response;
        }
    }
}
