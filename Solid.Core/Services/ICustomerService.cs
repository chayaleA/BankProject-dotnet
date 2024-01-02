using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        Customer Add(Customer customer);

        Customer Update(int id, Customer customer);

        void Remove(int id);
    }
}
