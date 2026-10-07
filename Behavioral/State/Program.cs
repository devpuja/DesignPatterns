using State;

var order = new Order(new PendingState());

order.Pay();
order.Ship();
order.Cancel();