﻿using bank_api_project;
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

        OfficialBank Add(OfficialBank officialBank);

        OfficialBank Update(int id, OfficialBank officialBank);

        void Remove(int id);
    }
}
