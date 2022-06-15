using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IEnumerable <Contract> GetPeople()
        {
            var dataset = Data.Serialization.LoadFromXML(@"C:\Users\StudentEN\Desktop\xml\dataset.xml");
            var contracts = dataset.SelectMany(n => n.Contracts);
            return contracts;
        }
    }
}
