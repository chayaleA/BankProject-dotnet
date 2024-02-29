using bank_api_project;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class OfficialBankRepository:IOfficalBankRepository
    {
        private readonly DataContext _data;

        public OfficialBankRepository(DataContext dateOfficialBank)
        {
            _data = dateOfficialBank;
        }

        public async Task<List<OfficialBank>> GetListAsync()
        {
            return await _data.OfficialBankList.ToListAsync();
        }

        public async Task<OfficialBank> AddAsync(OfficialBank officialBank)
        {
            _data.OfficialBankList.Add(officialBank);
            await _data.SaveChangesAsync();
            return officialBank;
        }

        public async Task<OfficialBank> UpdateAsync(int id, OfficialBank officialBank)
        {
            OfficialBank temp = _data.OfficialBankList.Find(id);
            if (temp == null)
            {
                _data.OfficialBankList.Add(officialBank);
                return null;
            }
            temp.Name = officialBank.Name;
            temp.Salary = officialBank.Salary;
            temp.Role = officialBank.Role;
            temp.Phone = officialBank.Phone;
            await _data.SaveChangesAsync();
            return officialBank;
        }

        public async Task RemoveAsync(int id)
        {
            OfficialBank temp = _data.OfficialBankList.Find(id);
            if (temp != null)
                _data.OfficialBankList.Remove(temp);
            await _data.SaveChangesAsync();
        }
    }
}
