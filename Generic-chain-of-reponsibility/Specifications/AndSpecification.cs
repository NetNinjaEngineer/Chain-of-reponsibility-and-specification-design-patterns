namespace Generic_chain_of_reponsibility.Specifications
{
    internal class AndSpecification<T> : BaseSpecification<T> where T : class
    {
        public AndSpecification() { }

        public AndSpecification(
            IBaseSpecification<T> specificationLeft,
            IBaseSpecification<T> specificationRight) : base(specificationLeft, specificationRight) { }

        public override bool IsSatisfiedBy(T entity)
            => _specificationLeft!.IsSatisfiedBy(entity) && _specificationRight!.IsSatisfiedBy(entity);
    }
}
