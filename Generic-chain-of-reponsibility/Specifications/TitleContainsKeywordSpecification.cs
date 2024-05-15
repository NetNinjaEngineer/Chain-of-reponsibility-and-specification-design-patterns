namespace Generic_chain_of_reponsibility.Specifications
{
    internal class TitleContainsKeywordSpecification : BaseSpecification<ExpenseReport>
    {
        private readonly string _keyword;

        public TitleContainsKeywordSpecification(string keyword)
        {
            _keyword = keyword;
        }

        public override bool IsSatisfiedBy(ExpenseReport entity)
        {
            return entity.Title!.Contains(_keyword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
