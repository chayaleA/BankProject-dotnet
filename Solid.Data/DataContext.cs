using bank_api_project;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext : DbContext
    {
        public readonly IConfiguration _configuration;
        public DbSet<OfficialBank> OfficialBankList { get; set; }

        public DbSet<Customer> CustomerList { get; set; }

        public DbSet<BankAccount> BankAcountsList { get; set; }

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionString"]);
            optionsBuilder.LogTo((message) => Debug.WriteLine(message));
        }
    }
}
