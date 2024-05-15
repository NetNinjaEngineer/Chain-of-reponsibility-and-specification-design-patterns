namespace Generic_chain_of_reponsibility
{
    internal class CEOApprovalHandler : ApprovalHandler<ExpenseReport, Response>
    {
        public override Response HandleRequest(ExpenseReport request)
            => new(true, $"CEO: Handling exceptional case of '{request.Title}' of amount {request.Amount:C}", ApprovedBy.CEO);
    }
}
