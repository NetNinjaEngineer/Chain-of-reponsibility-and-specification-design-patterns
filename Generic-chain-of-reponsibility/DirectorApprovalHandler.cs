namespace Generic_chain_of_reponsibility
{
    internal class DirectorApprovalHandler : ApprovalHandler<ExpenseReport, Response>
    {
        public DirectorApprovalHandler(decimal limit) : base(limit) { }

        public override Response HandleRequest(ExpenseReport request)
        {
            if (request.Amount > _limit)
                return new(true, $"Director: Approved document '{request.Title}' of amount {request.Amount:C}", ApprovedBy.Director);
            else
                return CallNext(request);
        }
    }
}
