using bank_api_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class BankAcountDto
    {
        public int Id { get; set; }
        public int BankAccountNumber { get; set; }

        public int UserId { get; set; }

        public Status Status { get; set; }

        public int Balance { get; set; }

        public int BankOperationId { get; set; }
    }
}
