using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank_api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService listCustomer;

        public CustomerController(ICustomerService listCustomer)
        {
            this.listCustomer = listCustomer;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return listCustomer.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            Customer temp = listCustomer.GetAll().Find(x => x.Id == id);
            if(temp == null)
                return NotFound();
            return temp;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Customer value)
        {
            return Ok(listCustomer.Add(value));
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer value)
        {
            return Ok(listCustomer.Update(id, value));
        }


        [HttpPut("{id}/Status")]
        public void Put(int id, [FromBody] Status status)
        {
            Customer temp = listCustomer.GetAll().Find(x => x.Id == id);
            if (temp == null)
                return;
            temp.Status = status;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listCustomer.Remove(id);
        }
    }
}
