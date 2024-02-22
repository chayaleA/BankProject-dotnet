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

        public async Task<OfficialBank> AddAsync(OfficialBank officialBank)
        {
            return await _officialBankRepository.AddAsync(officialBank);
        }

        public List<OfficialBank> GetAll()
        {
            return _officialBankRepository.GetList();
        }

        public async Task RemoveAsync(int id)
        {
            await _officialBankRepository.RemoveAsync(id);
        }

        public async Task<OfficialBank> UpdateAsync(int id, OfficialBank officialBank)
        {
            return await _officialBankRepository.UpdateAsync(id, officialBank);
        }
    }
}
