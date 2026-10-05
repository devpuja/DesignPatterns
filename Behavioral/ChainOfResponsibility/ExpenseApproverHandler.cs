namespace ChainOfResponsibility
{
    public abstract class ExpenseApproverHandler
    {
        protected ExpenseApproverHandler? _nextHandler;

        public void SetNextHandler(ExpenseApproverHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void Approve(ExpenseRequest request);
    }
}
