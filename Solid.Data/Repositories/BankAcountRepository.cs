using bank_api_project;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class BankAcountRepository : IBankAcountRepository
    {
        private readonly DataContext _dateBankAcount;

        public BankAcountRepository(DataContext dateBankAcount)
        {
            _dateBankAcount = dateBankAcount;
        }

        public List<BankAccount> GetList()
        {
            return _dateBankAcount.BankAcountsList.ToList();
        }
    }
}
