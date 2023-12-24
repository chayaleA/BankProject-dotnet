using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataBankAcount
    {
        public List<BankAccount> BankAcountsList { get; set; }

        public DataBankAcount()
        {
            BankAcountsList = new List<BankAccount>()
            {

              new BankAccount{BankAccountNumber=12345,Balance=5000,Status=Status.Active,userId=32544,
              withdrawals = new List<BankOperation>{ new BankOperation { Date = new DateTime()
              ,Sum = 50000}, new BankOperation { Date = new DateTime(), Sum = 50000 } }
             ,deposits = new List<BankOperation>{new BankOperation { Date = new DateTime(),Sum
              = 50000}, new BankOperation { Date = new DateTime(), Sum = 50000 }} }
              ,

            new BankAccount{BankAccountNumber=12345,Balance=5000,Status=Status.Active,userId=32544,
            withdrawals = new List<BankOperation>{ new BankOperation { Date = new DateTime()
            ,Sum = 50000}, new BankOperation { Date = new DateTime(), Sum = 50000 } }
            ,deposits = new List<BankOperation>{new BankOperation { Date = new DateTime(),Sum
            = 50000}, new BankOperation { Date = new DateTime(), Sum = 50000 }} },

            new BankAccount{BankAccountNumber=12345,Balance=5000,Status=Status.Active,userId=32544,
            withdrawals = new List<BankOperation>{ new BankOperation { Date = new DateTime()
            ,Sum = 50000}, new BankOperation { Date = new DateTime(), Sum = 50000 } }
            ,deposits = new List<BankOperation>{new BankOperation { Date = new DateTime(),Sum
             = 50000}, new BankOperation { Date = new DateTime(), Sum = 5000000 }} }
            };
        }
    }
}
