namespace bank_api_project.Models
{
    public class BankAcountPostModel
    {
        public int Id { get; set; }
        public int BankAccountNumber { get; set; }

        public int UserId { get; set; }

        public Status Status { get; set; }

        public int Balance { get; set; }

        public int BankOperationId { get; set; }
    }
}
