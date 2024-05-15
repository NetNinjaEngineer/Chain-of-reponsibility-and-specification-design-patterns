namespace Generic_chain_of_reponsibility
{
    internal interface IRequestHandler<TRequest> where TRequest : class
    {
        void Handle(TRequest request);
    }

    internal interface IApprovalHandler<TRequest, TResponse>
    {
        TResponse HandleRequest(TRequest request);
    }
}
