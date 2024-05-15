namespace Generic_chain_of_reponsibility.Specifications
{
    internal abstract class BaseSpecification<T> : IBaseSpecification<T> where T : class
    {
        protected readonly IBaseSpecification<T>? _specificationLeft;
        protected readonly IBaseSpecification<T>? _specificationRight;
        protected readonly IBaseSpecification<T>? _spec;

        public BaseSpecification() { }

        protected BaseSpecification(IBaseSpecification<T> specification)
            => _spec = specification;

        protected BaseSpecification(
            IBaseSpecification<T> specificationLeft,
            IBaseSpecification<T> specificationRight)
        {
            _specificationLeft = specificationLeft;
            _specificationRight = specificationRight;
        }

        public IBaseSpecification<T> And(IBaseSpecification<T> other)
            => new AndSpecification<T>(this, other);

        public abstract bool IsSatisfiedBy(T entity);

        public IBaseSpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public IBaseSpecification<T> Or(IBaseSpecification<T> other)
            => new OrSpecification<T>(this, other);
    }
}
