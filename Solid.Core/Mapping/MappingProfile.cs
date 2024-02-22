using AutoMapper;
using bank_api_project;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Mapping
{
    public class MappingProfile: Profile        
    {
       public MappingProfile()
        {
            CreateMap<BankAccount, BankAcountDto>().ReverseMap();

        }
    }
}
