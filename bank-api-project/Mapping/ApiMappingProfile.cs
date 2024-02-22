using AutoMapper;
using bank_api_project.Models;

namespace bank_api_project.Mapping
{
    public class ApiMappingProfile: Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<BankAcountPostModel, BankAccount>();
        }
    }
}
