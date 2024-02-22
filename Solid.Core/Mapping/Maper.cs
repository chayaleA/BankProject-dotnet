using bank_api_project;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Mapping
{
    public class Maper
    {
        public BankAcountDto MapToBankAcountDto(BankAccount bankAccount)
        {
            return new BankAcountDto { Id = bankAccount.Id ,BankAccountNumber = bankAccount.BankAccountNumber,
                Balance = bankAccount.Balance, Status = bankAccount.Status, UserId = bankAccount.UserId , BankOperationId = bankAccount.BankOperationId};
        }
    }
}
