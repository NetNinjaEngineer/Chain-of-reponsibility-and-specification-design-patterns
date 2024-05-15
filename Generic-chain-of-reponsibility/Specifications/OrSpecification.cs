namespace Generic_chain_of_reponsibility.Specifications
{
    internal class OrSpecification<T> : BaseSpecification<T> where T : class
    {
        public OrSpecification() { }

        public OrSpecification(IBaseSpecification<T> left,
            IBaseSpecification<T> right) : base(left, right) { }

        public override bool IsSatisfiedBy(T entity)
            => _specificationLeft!.IsSatisfiedBy(entity) || _specificationRight!.IsSatisfiedBy(entity);
    }
}
