namespace Generic_chain_of_reponsibility.Specifications
{
    internal class AmountGreaterThanSpecification : BaseSpecification<ExpenseReport>
    {
        private readonly int _amount;

        public AmountGreaterThanSpecification(int amount)
        {
            _amount = amount;
        }

        public override bool IsSatisfiedBy(ExpenseReport entity)
        {
            return entity.Amount > _amount;
        }
    }
}
