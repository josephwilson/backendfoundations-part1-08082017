using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _08082017.Controllers.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _08082017.Controllers
{

    [Route("api/[controller]")]
    public class AutomobilesController : Controller
    {

        //REST     -    CRUD
        //Create   -    Post
        //Read     -    Get
        //Put      -    Update
        //Delete   -    Delete
        private static List<Automobile> autos = new List<Automobile>();
        private static int idCounter = 0;

        // GET: api/values
        [HttpGet]
        public IEnumerable<Automobile> Get()
        {
            return autos;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Automobile Get(int id)
        {
            foreach(Automobile auto in autos)
            {
                if(auto.Id == id)
                {
                    return auto;
                }
            }
            return null;
        }

        // POST api/values
        [HttpPost]
        public Automobile Post([FromBody]Automobile automobile)
        {
            automobile.Id = idCounter++;
            autos.Add(automobile);
            return automobile;
        }

        // PUT api/values/5
        //put updates an entry
        [HttpPut("{id}")]
        public Automobile Put(int id, [FromBody]Automobile automobile)
        {
            foreach(Automobile auto in autos)
            {
                if(auto.Id == id)
                {
                    auto.Make = automobile.Make;
                    auto.Model = automobile.Model;
                    return auto;
                }
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for(int i = 0; i < autos.Count; i++)
            {
                if(autos[i].Id == id)
                {
                    autos.RemoveAt(i);
                }
            }
        }
    }
}
