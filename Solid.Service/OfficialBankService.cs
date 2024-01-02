using bank_api_project;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class OfficialBankService:IOfficalBankService
    {
        private readonly IOfficalBankRepository _officialBankRepository;

        public OfficialBankService(IOfficalBankRepository officialBankRepository)
        {
            _officialBankRepository = officialBankRepository;
        }

        public OfficialBank Add(OfficialBank officialBank)
        {
            return _officialBankRepository.Add(officialBank);
        }

        public List<OfficialBank> GetAll()
        {
            return _officialBankRepository.GetList();
        }

        public void Remove(int id)
        {
            _officialBankRepository.Remove(id);
        }

        public OfficialBank Update(int id, OfficialBank officialBank)
        {
            return _officialBankRepository.Update(id, officialBank);
        }
    }
}
