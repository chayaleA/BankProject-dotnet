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
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public void Remove(int id)
        {
            _customerRepository.Remove(id);
        }

        public Customer Update(int id, Customer customer)
        {
           return _customerRepository.Update(id,customer);
        }
        List<Customer> ICustomerService.GetAll()
        {
            return _customerRepository.GetList();
        }
    }
}
