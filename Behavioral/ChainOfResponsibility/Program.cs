using ChainOfResponsibility;

Manager manager = new();
Director director = new ();
VP vp = new ();

manager.SetNextHandler(director);
director.SetNextHandler(vp);


// Client call

var request = new ExpenseRequest(100);
manager.Approve(request);


var request2 = new ExpenseRequest(500);
manager.Approve(request2);


var request3 = new ExpenseRequest(2500);
manager.Approve(request3);