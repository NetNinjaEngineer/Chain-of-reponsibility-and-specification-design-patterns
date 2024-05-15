namespace Generic_chain_of_reponsibility.Specifications
{
    internal interface IBaseSpecification<T> where T : class
    {
        bool IsSatisfiedBy(T entity);
        IBaseSpecification<T> And(IBaseSpecification<T> other);
        IBaseSpecification<T> Or(IBaseSpecification<T> other);
        IBaseSpecification<T> Not();
    }
}
