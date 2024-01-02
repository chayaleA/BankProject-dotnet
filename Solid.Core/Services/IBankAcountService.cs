using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IBankAcountService
    {
        List<BankAccount> GetAll();

        BankAccount Add(BankAccount bankAccount);

        BankAccount Update(int id, BankAccount value);

        void Remove(int id);
    }
}
