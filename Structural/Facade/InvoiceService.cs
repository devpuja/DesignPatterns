
namespace Facade
{
    public interface IInvoiceService
    {
        void GenerateInvoice(string orderId, decimal amount);
    }

    public class InvoiceService : IInvoiceService
    {
        public void GenerateInvoice(string orderId, decimal amount)
        {
            Console.WriteLine($"Generated invoice for order {orderId} with amount ${amount:N2}.");
        }
    }
}