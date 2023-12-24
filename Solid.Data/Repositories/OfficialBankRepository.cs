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
        private readonly DataOfficalBank _dateOfficialBank;

        public OfficialBankRepository(DataOfficalBank dateOfficialBank)
        {
            _dateOfficialBank = dateOfficialBank;
        }

        public List<OfficialBank> GetList()
        {
            return _dateOfficialBank.OfficialBankList;
        }
    }
}
