﻿using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IOfficalBankRepository
    {
        List<OfficialBank> GetList();
    }
}