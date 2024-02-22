using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IOfficalBankService
    {
        List<OfficialBank> GetAll();

        Task<OfficialBank> AddAsync(OfficialBank officialBank);

        Task<OfficialBank> UpdateAsync(int id, OfficialBank officialBank);

        Task RemoveAsync(int id);
    }
}
