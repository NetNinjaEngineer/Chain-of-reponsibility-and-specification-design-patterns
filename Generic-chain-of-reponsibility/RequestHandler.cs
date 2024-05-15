namespace Generic_chain_of_reponsibility
{
    internal abstract class RequestHandler<TRequest>
        : IRequestHandler<TRequest> where TRequest : class
    {
        protected IRequestHandler<TRequest>? _next;

        public void SetNext(IRequestHandler<TRequest> next)
            => _next = next;

        protected void CallNextHandler(TRequest request)
        {
            _next?.Handle(request);
        }

        public abstract void Handle(TRequest request);
    }
}
