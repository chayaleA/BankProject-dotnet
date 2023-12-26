using bank_api_project;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<OfficialBank> OfficialBankList { get; set; }

        public DbSet<Customer> CustomerList { get; set; }

        public DbSet<BankAccount> BankAcountsList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=firstDB");
        }
    }
}
