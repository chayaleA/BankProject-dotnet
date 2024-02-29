using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank_api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficialBankController : ControllerBase
    {

        private readonly IOfficalBankService listOfficials;

        public OfficialBankController(IOfficalBankService listOfficials)
        {
            this.listOfficials = listOfficials;
        }

        [HttpGet]
        public async Task<IEnumerable<OfficialBank>> Get()
        {
            Console.WriteLine("OfficialBankController.get start :: " + HttpContext.Items["guid"]);
            return await listOfficials.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OfficialBank>> Get(int id)
        {
            var list = await listOfficials.GetAllAsync();
            OfficialBank temp = list.Find(e => e.Id == id);
            if (temp == null)
                return NotFound();
            return temp;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OfficialBank value)
        {
            return Ok( await listOfficials.AddAsync(value));
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] OfficialBank value)
        {
            return Ok(await listOfficials.UpdateAsync(id, value));
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await listOfficials.RemoveAsync(id);
        }
    }
}
