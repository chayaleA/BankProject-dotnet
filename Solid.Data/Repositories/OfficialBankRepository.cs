using bank_api_project;
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

        public List<OfficialBank> GetList()
        {
            return _data.OfficialBankList.ToList();
        }

        public OfficialBank Add(OfficialBank officialBank)
        {
            _data.OfficialBankList.Add(officialBank);
            _data.SaveChanges();
            return officialBank;
        }

        public OfficialBank Update(int id, OfficialBank officialBank)
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
            _data.SaveChanges();
            return officialBank;
        }

        public void Remove(int id)
        {
            OfficialBank temp = _data.OfficialBankList.Find(id);
            if (temp != null)
                _data.OfficialBankList.Remove(temp);
            _data.SaveChanges();
        }
    }
}
