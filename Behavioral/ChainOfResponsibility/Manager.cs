namespace ChainOfResponsibility
{
    public class Manager : ExpenseApproverHandler
    {
        public override void Approve(ExpenseRequest request)
        {
            if (request.Amount <= 1000)
            {
                Console.WriteLine($"Manager approved the expense request of {request.Amount}\n");
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
