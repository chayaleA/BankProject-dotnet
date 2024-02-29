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
        public async Task<IEnumerable<Customer>> Get()
        {
            Console.WriteLine("CustomerController.get start :: " + HttpContext.Items["guid"]);
            return await listCustomer.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> Get(int id)
        {
            var list = await listCustomer.GetAllAsync();
            Customer temp = list.Find(x => x.Id == id);
            if(temp == null)
                return NotFound();
            return temp;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Customer value)
        {
            return Ok(await listCustomer.AddAsync(value));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Customer value)
        {
            return Ok(await listCustomer.UpdateAsync(id, value));
        }


        [HttpPut("{id}/Status")]
        public async Task Put(int id, [FromBody] Status status)
        {
            var list = await listCustomer.GetAllAsync();
            Customer temp = list.Find(x => x.Id == id);
            if (temp == null)
                return;
            temp.Status = status;
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            listCustomer.RemoveAsync(id);
        }
    }
}
