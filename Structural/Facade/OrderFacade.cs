using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class OrderFacade
    {
        private readonly IInventoryService _inventoryService;
        private readonly IPaymentService _paymentService;
        private readonly IInvoiceService _invoiceService;
        private readonly IEmailService _emailService;

        public OrderFacade(IInventoryService inventoryService, IPaymentService paymentService, IInvoiceService invoiceService, IEmailService emailService)
        {
            _inventoryService = inventoryService;
            _paymentService = paymentService;
            _invoiceService = invoiceService;
            _emailService = emailService;
        }

        public void PlaceOrder(string productId, int quantity, string orderId, decimal amount, string email)
        {
            _inventoryService.ReserveInventory(productId, quantity);
            _paymentService.ProcessPayment(orderId, amount);
            _invoiceService.GenerateInvoice(orderId, amount);
            _emailService.SendEmail(email);
        }
    }
}
