﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank_api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        //...
    }

    public class BankAccountController : ControllerBase
    {
        private readonly IBankAcountService ListBankAccounts;
        //private readonly Mapper mapper;
        private readonly IMapper _mapper;

        public BankAccountController(IBankAcountService ListBankAccounts1, IMapper mapper)
        {
            ListBankAccounts = ListBankAccounts1;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankAccount>>> Get()
        {
            Console.WriteLine("BankAccountController.get start :: " + HttpContext.Items["guid"]);
            var list = await ListBankAccounts.GetAllAsync();
            var listDto = _mapper.Map<IEnumerable<BankAcountDto>>(list);
            Console.WriteLine("BankAccountController.get end :: " + HttpContext.Items["guid"]);
            return Ok(listDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BankAccount>> Get(int id, int? balance, Status?status, int? UserId)
        {
            var temp1 = await ListBankAccounts.GetAllAsync();
            var temp = temp1.Find(e => e.BankAccountNumber == id);

           // var bankAcountDto = _mapper.Map<BankAcountDto>(temp);
            if(temp== null)
                return NotFound();

            var bankAcountDto = _mapper.Map<BankAcountDto>(temp);
            return Ok(bankAcountDto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] BankAccount bankAccount)
        {
            var BankAcountToAdd = new BankAccount
            {
                Id = bankAccount.Id,
                BankAccountNumber = bankAccount.BankAccountNumber,
                Balance = bankAccount.Balance,
                Status = bankAccount.Status,
                UserId = bankAccount.UserId,
                BankOperationId = bankAccount.BankOperationId
            };
            await ListBankAccounts.AddAsync(BankAcountToAdd);

            var bankAcountDto = _mapper.Map<BankAcountDto>(BankAcountToAdd);
            return Ok(bankAcountDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] BankAccount value)
        {
            return  Ok(await ListBankAccounts.UpdateAsync(id,value));
        }

        [HttpPut("{id}/Status")]
        public async Task Put(int id, [FromBody] Status status)
        {
            var list = await ListBankAccounts.GetAllAsync();
            BankAccount temp = list.Find(x => x.BankAccountNumber == id);
            if (temp == null)
                return;
            temp.Status = status;
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await ListBankAccounts.RemoveAsync(id);
        }
    }
}
