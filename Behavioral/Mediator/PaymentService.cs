using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class PaymentService
    {
        private readonly IApplicationMediator _mediator;
        public PaymentService(IApplicationMediator mediator)
        {
            _mediator = mediator;
        }
        public void ProcessPayment()
        {
            Console.WriteLine("PaymentService: Processing payment...");
            _mediator.NotifyUserPaymentCompleted();
        }
    }
}
