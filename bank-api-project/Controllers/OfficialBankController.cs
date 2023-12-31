﻿using Microsoft.AspNetCore.Identity;
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
        public IEnumerable<OfficialBank> Get()
        {
            return listOfficials.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<OfficialBank> Get(int id)
        {
            OfficialBank temp = listOfficials.GetAll().Find(e => e.Id == id);
            if (temp == null)
                return NotFound();
            return temp;
        }

        [HttpPost]
        public ActionResult Post([FromBody] OfficialBank value)
        {
            return Ok(listOfficials.Add(value));
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OfficialBank value)
        {
            return Ok(listOfficials.Update(id, value));
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listOfficials.Remove(id);
        }
    }
}
