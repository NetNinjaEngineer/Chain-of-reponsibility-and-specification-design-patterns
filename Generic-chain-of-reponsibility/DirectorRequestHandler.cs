namespace Generic_chain_of_reponsibility
{
    internal class DirectorRequestHandler : RequestHandler<ExpenseReport>
    {
        private readonly decimal _limit;

        public DirectorRequestHandler(decimal limit)
        {
            _limit = limit;
        }

        public override void Handle(ExpenseReport request)
        {
            if (request.Amount > _limit)
                Console.WriteLine($"Director: Approved document '{request.Title}' of amount {request.Amount}");
            else if (_next != null)
                CallNextHandler(request);
            else
                Console.WriteLine($"Director: Can not handle the request and no handler" +
                    $" in the chain to handle this request.");
        }
    }
}
