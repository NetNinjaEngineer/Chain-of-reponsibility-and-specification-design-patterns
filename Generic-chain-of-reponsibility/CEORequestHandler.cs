namespace Generic_chain_of_reponsibility
{
    internal class CEORequestHandler : RequestHandler<ExpenseReport>
    {
        public override void Handle(ExpenseReport request)
            => Console.WriteLine($"CEO: Handling exceptional case for document '{request.Title}' of amount ${request.Amount}");
    }
}
