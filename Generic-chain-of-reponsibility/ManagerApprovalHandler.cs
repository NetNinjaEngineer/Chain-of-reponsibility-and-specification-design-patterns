namespace Generic_chain_of_reponsibility
{
    internal class ManagerApprovalHandler : ApprovalHandler<ExpenseReport, Response>
    {
        public ManagerApprovalHandler(decimal limit) : base(limit) { }
        public override Response HandleRequest(ExpenseReport request)
        {
            if (request.Amount <= _limit)
                return new(true, $"Manager: Approved document '{request.Title}' of amount {request.Amount:C}", ApprovedBy.Manager);
            else
                return CallNext(request);
        }
    }
}