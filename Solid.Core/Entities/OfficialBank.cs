namespace bank_api_project
{
    public enum Degree { Withrawal, Loan, Deposit }
    public class OfficialBank
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }
        public int Salary { get; set; }
        public Degree Role { get; set;}
    }
}
