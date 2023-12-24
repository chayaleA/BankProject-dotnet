using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataCustomer
    {
        public List<Customer> CustomerList { get; set; }

        public DataCustomer()
        {
            CustomerList = new List<Customer>()
             {
                  new Customer{ Name = "Yael",Id = 123456789, Phone = "0583238801", Status = Status.Active ,BankAccountNumber = 12324566},
                  new Customer{ Name = "Pnina",Id = 123456789, Phone ="0583238801", Status = Status.Active ,BankAccountNumber = 12324566},
                  new Customer{ Name = "Chaya",Id = 123456789, Phone ="0583238801", Status = Status.Active ,BankAccountNumber = 12324566}
             };
        }
    }
}
