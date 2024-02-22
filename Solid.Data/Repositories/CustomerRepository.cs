using bank_api_project;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _dateCustomer;

        public CustomerRepository(DataContext dateCustomer)
        {
            _dateCustomer = dateCustomer;
        }

        public List<Customer> GetList()
        {
            return _dateCustomer.CustomerList.ToList();
        }

        public async Task<Customer> AddAsync(Customer customer)
        {
            _dateCustomer.CustomerList.Add(customer);
            await _dateCustomer.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> UpdateAsync(int id, Customer customer)
        {
            Customer temp = _dateCustomer.CustomerList.Find(id);
            if (temp == null)
            {
                _dateCustomer.CustomerList.Add(customer);
                return null; ;
            }
            temp.Phone = customer.Phone;
            temp.Status = customer.Status;
            temp.BankAccountNumber = customer.BankAccountNumber;
            await _dateCustomer.SaveChangesAsync();
            return customer;
        }

        public async Task RemoveAsync(int id)
        {
            Customer temp = _dateCustomer.CustomerList.Find(id);
            if (temp != null)
                _dateCustomer.CustomerList.Remove(temp);
            await _dateCustomer.SaveChangesAsync();
        }
    }
}
