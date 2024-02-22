using bank_api_project;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data.Repositories
{
    public class BankAcountRepository : IBankAcountRepository
    {
        private readonly DataContext _dateBankAcount;

        public BankAcountRepository(DataContext dateBankAcount)
        {
            _dateBankAcount = dateBankAcount;
        }

        public async Task<BankAccount> AddAsync(BankAccount bankAccount)
        {
            _dateBankAcount.BankAcountsList.Add(bankAccount);
            await _dateBankAcount.SaveChangesAsync();
            return bankAccount;
        }
        public async Task RemoveAsync(int id)
        {
            BankAccount temp = _dateBankAcount.BankAcountsList.Find(id);
            if (temp != null)
                _dateBankAcount.BankAcountsList.Remove(temp);
            await _dateBankAcount.SaveChangesAsync();
        }

        public async Task<BankAccount> UpdateAsync(int id,BankAccount bankAccount)
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
            await _dateBankAcount.SaveChangesAsync();
            return bankAccount;
        }

        public List<BankAccount> GetList()
        {
            return _dateBankAcount.BankAcountsList.Include(u => u.withdrawals).Include(u => u.deposits).ToList();
        }    
    }
}
