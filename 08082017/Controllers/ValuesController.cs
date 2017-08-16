using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _08082017.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //each method handles a different http request,
        //often called end points and each one matches
        //a particular crud operation
        //rest api = representational state trasnfer


        // GET api/values
        [HttpGet] // <= [stuff] is a decorator, returns an IEnumerable list of all values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        // queries database returning the value whose id matched the value passed in, it would be domain.tld/id
        //it only returns one value, not a list, because id should be unique
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        //creates soething new, adds it to the db
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        //updates the value who's id matches the id in the request, domain.tld/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        //deletes the value whose id matches the in in the request, domain.tld/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
