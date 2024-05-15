namespace Generic_chain_of_reponsibility.Specifications
{
    internal class NotSpecification<T> : BaseSpecification<T> where T : class
    {
        public NotSpecification(IBaseSpecification<T> specification) : base(specification) { }

        public override bool IsSatisfiedBy(T entity)
            => !_spec.IsSatisfiedBy(entity);
    }
}
