using Observer;

var orderService = new OrderService();

var emailService = new EmailService();
var smsService = new SMSService();
var analyticsService = new AnalyticsService();

orderService.Subscribe(emailService);
orderService.Subscribe(smsService);
orderService.Subscribe(analyticsService);

// Unsubscribe SMSService
// orderService.Unsubscribe(smsService);

orderService.PlaceOrder(101);