using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetList();

        Task<Customer> AddAsync(Customer customer);

        Task<Customer> UpdateAsync(int id, Customer customer);

        Task RemoveAsync(int id);
    }
}
