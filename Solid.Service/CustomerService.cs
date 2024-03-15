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

        public async Task<Customer> AddAsync(Customer customer)
        {
            return await _customerRepository.AddAsync(customer);
        }

        public async Task RemoveAsync(int id)
        {
            await _customerRepository.RemoveAsync(id);
        }

        public async Task<Customer> UpdateAsync(int id, Customer customer)
        {
           return await _customerRepository.UpdateAsync(id,customer);
        }
        async Task<List<Customer>> ICustomerService.GetAllAsync()
        {
            return await _customerRepository.GetListAsync();
        }

        public Customer GetByCustomerNameAndPassword(string customerName, string customerPassword)
        {
            return _customerRepository.GetByCustomerNameAndPassword(customerName, customerPassword);
        }
    }
}
