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
        public void Post([FromBody] Customer value)
        {
            listCustomer.GetAll().Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            Customer temp = listCustomer.GetAll().Find(x => x.Id == id);
            if (temp == null)
            {
                listCustomer.GetAll().Add(value);
                return;
            }
            temp.Id = value.Id;
            temp.Phone = value.Phone;
            temp.Status = value.Status;
            temp.BankAccountNumber = value.BankAccountNumber;
        }


        [HttpPut("{id}/Status")]
        public void Put(int id, [FromBody] Status status)
        {
            Customer temp = listCustomer.GetAll().Find(x => x.Id == id);
            if (temp == null)
                return;
            temp.Status = status;
        }
    }
}
