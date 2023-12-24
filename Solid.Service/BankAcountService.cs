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
        public List<BankAccount> GetAll()
        {
            return _bankAcountRepository.GetList();
        }
    }
}