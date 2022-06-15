using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("GetAll")]
        public List<Person> GetPeople() {
            var dataset = Data.Serialization.LoadFromXML(@"C:\Users\StudentEN\Desktop\xml\dataset.xml");
            return dataset;
        }

    


  
 
    
        [HttpGet("ByEmail/{email}")]
        public Person? GetPeople1(string email)
        {
            var dataset = Data.Serialization.LoadFromXML(@"C:\Users\StudentEN\Desktop\xml\dataset.xml");

            return dataset.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }


    }
}

