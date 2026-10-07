using Strategy;

var paymentPP = new PaymentService(new PayPalStrategy()); ;
paymentPP.MakePayment(1000);


var paymentCC = new PaymentService(new CreditCardStrategy()); ;
paymentCC.MakePayment(2000);


var paymentUPI = new PaymentService(new UpiStrategy());
paymentUPI.MakePayment(1000.90m);