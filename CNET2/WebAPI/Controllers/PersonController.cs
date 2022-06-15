using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly peopleContext _db;
        public PersonController(peopleContext db) {
            _db = db;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Person> GetPeople() {
            var db =  new Data.peopleContext();
            return _db.Persons;
        }

    


  
 
    
        [HttpGet("ByEmail/{email}")]
        public Person? GetPeople1(string email)
        {
            var db = new Data.peopleContext();

            return _db.Persons.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }


    }
}

