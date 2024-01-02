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

        public Customer Add(Customer customer)
        {
            _dateCustomer.CustomerList.Add(customer);
            _dateCustomer.SaveChanges();
            return customer;
        }

        public Customer Update(int id, Customer customer)
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
            _dateCustomer.SaveChanges();
            return customer;
        }

        public void Remove(int id)
        {
            Customer temp = _dateCustomer.CustomerList.Find(id);
            if (temp != null)
                _dateCustomer.CustomerList.Remove(temp);
            _dateCustomer.SaveChanges();
        }
    }
}
