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

        public BankAccount Add(BankAccount bankAccount)
        {
            _dateBankAcount.BankAcountsList.Add(bankAccount);
            _dateBankAcount.SaveChanges();
            return bankAccount;
        }
        public void Remove(int id)
        {
            BankAccount temp = _dateBankAcount.BankAcountsList.Find(id);
            if (temp != null)
                _dateBankAcount.BankAcountsList.Remove(temp);
            _dateBankAcount.SaveChanges();
        }

        public BankAccount Update(int id,BankAccount bankAccount)
        {
            BankAccount temp = _dateBankAcount.BankAcountsList.Find(id);
            if (temp == null)
            {
                _dateBankAcount.BankAcountsList.Add(bankAccount);
                return null;
            }
            temp.BankAccountNumber = bankAccount.BankAccountNumber;
 
            temp.Status = bankAccount.Status;
            temp.deposits = bankAccount.deposits;
            temp.withdrawals = bankAccount.withdrawals;
            temp.Balance = bankAccount.Balance;
            _dateBankAcount.SaveChanges();
            return bankAccount;
        }

        public List<BankAccount> GetList()
        {
            return _dateBankAcount.BankAcountsList.ToList();
        }

       
    }
}
