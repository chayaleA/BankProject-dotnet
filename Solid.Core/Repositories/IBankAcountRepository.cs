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
        Task<List<BankAccount>> GetListAsync();

        Task<BankAccount> AddAsync(BankAccount bankAccount);

        Task<BankAccount> UpdateAsync(int id, BankAccount value);

        Task RemoveAsync(int id);
    }
}
