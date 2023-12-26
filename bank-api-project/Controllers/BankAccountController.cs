using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank_api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAcountService ListBankAccounts;

        public BankAccountController(IBankAcountService ListBankAccounts1)
        {
            ListBankAccounts = ListBankAccounts1;
        }
        [HttpGet]
        public IEnumerable<BankAccount> Get()
        {
            return ListBankAccounts.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<BankAccount> Get(int id, int? balance, Status?status, int? UserId)
        {
            BankAccount temp = ListBankAccounts.GetAll().Find(e => e.BankAccountNumber == id);
            if(temp!= null)
                return temp;
            return NotFound();
        }

        [HttpPost]
        public void Post([FromBody] BankAccount value)
        {
            ListBankAccounts.GetAll().Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BankAccount value)
        {

            BankAccount temp = ListBankAccounts.GetAll().Find(x => x.BankAccountNumber == id);
            if (temp == null)
            {
                ListBankAccounts.GetAll().Add(value);
                return;
            }
            temp.BankAccountNumber = value.BankAccountNumber;
            temp.Id = value.Id;
            temp.Status = value.Status;
            temp.deposits = value.deposits;
            temp.withdrawals = value.withdrawals;
            temp.Balance = value.Balance;
        }

        [HttpPut("{id}/Status")]
        public void Put(int id, [FromBody] Status status)
        {
            BankAccount temp = ListBankAccounts.GetAll().Find(x => x.BankAccountNumber == id);
            if (temp == null)
                return;
            temp.Status = status;
        }

    }
}
