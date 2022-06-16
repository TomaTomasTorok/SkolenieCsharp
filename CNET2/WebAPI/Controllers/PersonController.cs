using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return _db.Persons.Include(x => x.Contracts)
                .Include(x => x.HomeAddress)   ;
        }

    


  
 
    
        [HttpGet("ByEmail/{email}")]
        public Person? GetPeople1(string email)
        {
            var db = new Data.peopleContext();

            return _db.Persons.Include(x => x.Contracts)
                .Include(x => x.HomeAddress).Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }

        [HttpGet("ByPersonId/{id}")]
        public Person? GetPeopleID(int id)
        {
            var db = new Data.peopleContext();

            return _db.Persons.Include(x => x.Contracts)
                              .Include(x => x.HomeAddress)
                              .FirstOrDefault(x => x.Id == id);
        }

    }
}

