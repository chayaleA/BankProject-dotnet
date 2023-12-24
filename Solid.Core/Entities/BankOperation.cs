namespace bank_api_project
{
    public class BankOperation
    {
        private static int count = 0;

        public int Id { get;  } = ++count;
        public DateTime Date { get; set; }

        public int Sum { get; set; }
    }
}
