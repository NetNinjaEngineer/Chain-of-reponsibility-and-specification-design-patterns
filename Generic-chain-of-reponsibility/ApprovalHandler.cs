namespace Generic_chain_of_reponsibility
{
    internal abstract class ApprovalHandler<TRequest, TResponse> : IApprovalHandler<TRequest, TResponse>
    {
        protected readonly decimal _limit;

        protected ApprovalHandler() { }

        protected ApprovalHandler(decimal limit)
            => _limit = limit;

        private IApprovalHandler<TRequest, TResponse>? _next;

        public void SetNext(IApprovalHandler<TRequest, TResponse> next)
            => _next = next;

        protected TResponse CallNext(TRequest request)
            => _next!.HandleRequest(request);

        public abstract TResponse HandleRequest(TRequest request);
    }
}
