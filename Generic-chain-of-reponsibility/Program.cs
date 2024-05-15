using Generic_chain_of_reponsibility.Specifications;

namespace Generic_chain_of_reponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ExpenseReport> expenseReports =
            [
                new(title: "Purchase Office Supplies", amount: 2000),
                new(title: "Buy New Laptops", amount: 1500),
                new(title: "Initiate Project X", amount: 7000)
            ];

            List<ApprovalHandler<ExpenseReport, Response>> approvalHandlers =
            [
                new ManagerApprovalHandler(1000),
                new DirectorApprovalHandler(5000),
                new CEOApprovalHandler()
            ];


            List<RequestHandler<ExpenseReport>> requestHandlers =
            [
                new ManagerRequestHandler(1000),
                new DirectorRequestHandler(5000),
                new CEORequestHandler()
            ];

            //foreach (var result in HandleRequests(expenseReports, approvalHandlers))
            //    Console.WriteLine(result);

            //Console.WriteLine("\n\n\n\n-----------------------------");

            //HandleRequests(expenseReports, requestHandlers);

            RunSpecificationsDemo();

            Console.ReadKey();
        }

        private static void HandleRequests(
            List<ExpenseReport> requests,
            List<RequestHandler<ExpenseReport>> requestHandlers)
        {
            requestHandlers[0].SetNext(requestHandlers[1]);
            requestHandlers[1].SetNext(requestHandlers[2]);

            foreach (var request in requests)
            {
                requestHandlers[0].Handle(request);
            }
        }

        private static IEnumerable<Response> HandleRequests(
            List<ExpenseReport> requests,
            List<ApprovalHandler<ExpenseReport, Response>> handlers)
        {
            handlers[0].SetNext(handlers[1]);
            handlers[1].SetNext(handlers[2]);

            foreach (var request in requests)
            {
                yield return handlers[0].HandleRequest(request);
            }

        }

        private static void RunSpecificationsDemo()
        {
            List<ExpenseReport> expenseReports =
            [
                new(title: "Purchase Office Supplies", amount: 2000),
                new(title: "Buy New Laptops", amount: 1500),
                new(title: "Initiate Project X", amount: 7000)
            ];

            var amountGreaterThan1000 = new AmountGreaterThanSpecification(1000);
            var titleContainsOffice = new TitleContainsKeywordSpecification("Office");

            var complexSpecification = amountGreaterThan1000.And(titleContainsOffice);

            var filteredReports = expenseReports.Where(doc => complexSpecification.IsSatisfiedBy(doc));

            foreach (var item in filteredReports)
            {
                Console.WriteLine($"{item.Title}");
            }

        }
    }
}
