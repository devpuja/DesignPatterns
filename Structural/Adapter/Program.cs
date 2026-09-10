using Adapter;

// Create an instance of the legacy payment gateway
var legacyPaymentGateway = new LegacyPaymentGateway();

// Create an adapter for the legacy payment gateway
IPaymentProcessor paymentAdapter = new PaymentAdapter(legacyPaymentGateway);

// Create a checkout service that uses the payment adapter
var checkoutService = new CheckoutService(paymentAdapter);

// Perform a checkout with a specified amount
decimal amountToPay = 100.00m;
checkoutService.Checkout(amountToPay);