namespace ChainOfResponsibility
{
    public class ExpenseRequest
    {
        public decimal Amount { get; set; }
        public ExpenseRequest(decimal _amount)
        {
            Amount = _amount;
        }
    }
}
