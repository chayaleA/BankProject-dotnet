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
        Task<List<BankAccount>> GetAllAsync();

        Task<BankAccount> AddAsync(BankAccount bankAccount);

        Task<BankAccount> UpdateAsync(int id, BankAccount bankAccount);

        Task RemoveAsync(int id);
    }
}
