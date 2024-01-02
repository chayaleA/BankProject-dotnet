using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IBankAcountRepository
    {
        List<BankAccount> GetList();

        BankAccount Add(BankAccount bankAccount);

        BankAccount Update(int id, BankAccount value);

        void Remove(int id);
    }
}
