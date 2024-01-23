namespace bank_api_project
{
    public class BankAccount
    {
        public int BankAccountNumber { get; set; }

        public int Id { get; set; }
        public int UserId { get;set; }

        public Status Status { get; set; }

        public int Balance { get;set; }

        public int BankOperationId { get; set; }
        public List<BankOperation> withdrawals { get; set; }
        public List<BankOperation> deposits { get; set; }
    }
}
