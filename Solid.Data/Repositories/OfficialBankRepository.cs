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
    }
}
