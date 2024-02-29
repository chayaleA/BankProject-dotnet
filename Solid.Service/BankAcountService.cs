using bank_api_project;
using Solid.Core.Repositories;
using Solid.Core.Services;

namespace Solid.Service
{
    public class BankAcountService : IBankAcountService
    {
        private readonly IBankAcountRepository _bankAcountRepository;

        public BankAcountService(IBankAcountRepository bankAcountRepository)
        {
            _bankAcountRepository = bankAcountRepository;
        }

        public async Task<BankAccount> AddAsync(BankAccount bankAccount)
        {
            return await _bankAcountRepository.AddAsync(bankAccount);
        }
        public async Task<BankAccount> UpdateAsync(int id, BankAccount bankAccount)
        {
            return await _bankAcountRepository.UpdateAsync(id, bankAccount);
        }
        public async Task<List<BankAccount>> GetAllAsync()
        {
            return await _bankAcountRepository.GetListAsync();
        }

        public async Task RemoveAsync(int id)
        {
            await _bankAcountRepository.RemoveAsync(id);
        }
    }
}