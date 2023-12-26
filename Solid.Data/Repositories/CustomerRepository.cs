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
    }
}
