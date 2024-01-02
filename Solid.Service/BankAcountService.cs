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

        public BankAccount Add(BankAccount bankAccount)
        {
            return _bankAcountRepository.Add(bankAccount);
        }
        public BankAccount Update(int id, BankAccount bankAccount)
        {
            return _bankAcountRepository.Update(id, bankAccount);
        }
        public List<BankAccount> GetAll()
        {
            return _bankAcountRepository.GetList();
        }

        public void Remove(int id)
        {
            _bankAcountRepository.Remove(id);
        }
    }
}