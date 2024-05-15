namespace Generic_chain_of_reponsibility
{
    internal class ExpenseReport
    {
        public ExpenseReport(string? title, decimal amount)
        {
            Title = title;
            Amount = amount;
        }

        public string? Title { get; set; }
        public decimal Amount { get; set; }
    }
}
