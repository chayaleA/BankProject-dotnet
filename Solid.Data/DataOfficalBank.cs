using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataOfficalBank
    {
        public List<OfficialBank> OfficialBankList { get; set; }

        public DataOfficalBank()
        {
            OfficialBankList = new List<OfficialBank>()
            {
                new OfficialBank{Name = "Yael",Id = 123456789, Phone = "0583238801", Role = Degree.Withrawal,Salary = 100},
                new OfficialBank{Name = "Pnina",Id = 123456789, Phone ="0583238801", Role = Degree.Withrawal,Salary = 100},
                new OfficialBank{Name = "Chaya",Id = 123456789, Phone ="0583238801", Role = Degree.Withrawal,Salary = 100},
                new OfficialBank{Name = "Yael",Id = 123456789, Phone = "0583238801", Role = Degree.Withrawal,Salary = 100}
            };
        }
    }
}
