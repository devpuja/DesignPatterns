namespace ChainOfResponsibility
{
    public class Director: ExpenseApproverHandler
    {
        public override void Approve(ExpenseRequest request)
        {
            if (request.Amount <= 5000)
            {
                Console.WriteLine($"Director approved the expense request of {request.Amount}\n");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Approve(request);
            }
            else
            {
                Console.WriteLine($"Expense request of {request.Amount} requires further approval.\n");
            }
        }
    }
}
