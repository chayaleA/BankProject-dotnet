namespace bank_api_project
{
    public enum Status { InActive, Active }
    public class Customer
    {
        public string Name { get; set; }
        //public string Password { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }
        public int BankAccountNumber { get; set; }
        public Status Status { get;set; }
    }
}
