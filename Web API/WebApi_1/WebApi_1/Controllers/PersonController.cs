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
       static List<Person> personlist = new List<Person>()
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

        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetPersonNameById(int pId)
        {
            string pname = personlist.Where(p => p.Id == pId).SingleOrDefault()?.Personname;

            if(pname == null)
            {
                return NotFound();
            }
            return Ok(pname);
        }

        //Post 1
        [HttpPost]
        [Route("AllPost")]
        public List<Person>PostAll([FromBody] Person person)
        {
            personlist.Add(person);
            return personlist;
        }

        //Post 2
        [HttpPost]
        [Route("personPost")]
        public IEnumerable<Person>PersonPost([FromUri]int Id, string name, string job)
        {
            Person person = new Person();
            person.Id = Id;
            person.Personname = name;
            person.PersonJob = job;
            personlist.Add(person);
            return personlist;
        }

        [HttpPut]
        [Route("updperson")]
        public Person Put(int pid, [FromUri]string name, string job, string gender)
        {
            var pList = personlist[pid - 1];
            pList.Id = pid;
            pList.Personname = name;
            pList.PersonJob = job;
            pList.Gender = gender;
            return pList;
        }

        //put 2

        [HttpPut]
        [Route("newput")]
        public IEnumerable<Person>Put(int pid,[FromBody] Person p)
        {
            personlist[pid - 1] = p;
            return personlist;
        }

        [HttpDelete]
        [Route("delperson")]
        public IEnumerable<Person>Delete(int pid)
        {
            personlist.RemoveAt(pid - 1);
            return personlist;
        }
    }
}
