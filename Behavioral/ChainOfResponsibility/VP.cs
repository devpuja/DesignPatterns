namespace ChainOfResponsibility
{
    public class VP : ExpenseApproverHandler
    {
        public override void Approve(ExpenseRequest request)
        {
            if (request.Amount <= 25000)
            {
                Console.WriteLine($"VP approved the expense request of {request.Amount}\n");
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
