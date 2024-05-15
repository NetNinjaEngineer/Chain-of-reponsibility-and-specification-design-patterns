namespace Generic_chain_of_reponsibility
{
    internal class ManagerRequestHandler : RequestHandler<ExpenseReport>
    {
        private readonly decimal _approveLimit;

        public ManagerRequestHandler(decimal approveLimit)
        {
            _approveLimit = approveLimit;
        }

        public override void Handle(ExpenseReport request)
        {
            if (request.Amount < _approveLimit)
                Console.WriteLine($"Manager: Approved document '{request.Title}' of amount ${request.Amount}");
            else if (_next is not null)
                CallNextHandler(request);
            else
                Console.WriteLine($"Manager: Cannot approve document '{request.Title}' of amount ${request.Amount} and no successor to handle it");
        }
    }
}
