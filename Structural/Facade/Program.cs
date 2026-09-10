using Facade;

OrderFacade orderFacade = new OrderFacade(new InventoryService(), new PaymentService(), new InvoiceService(), new EmailService());

orderFacade.PlaceOrder("product-001", 20, "order-123", 100.00m, "customer@example.com");