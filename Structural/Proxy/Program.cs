using Proxy;

Console.WriteLine("====== Virtual Proxy (Lazy Loading) ======");
IDocument virtualDoc = new VirtualDocumentProxy("report.pdf");
Console.WriteLine("Proxy created, but document not loaded yet.");
// Only now does the real document get loaded
virtualDoc.Render();


Console.WriteLine("\n====== Protection Proxy (Access Control) ======");
IDocument realDoc = new RealDocument("confidential.pdf");

var adminUser = new User("Alice", "Admin");
var viewerUser = new User("Bob", "Viewer");

IDocument adminProxy = new ProtectedDocumentProxy(realDoc, adminUser);
IDocument viewerProxy = new ProtectedDocumentProxy(realDoc, viewerUser);

adminProxy.Render();
viewerProxy.Render();


Console.WriteLine("\n====== Remote Proxy (Network Boundary) ======");
var remoteService = new RemoteDocumentService();
IDocument remoteDoc = new RemoteDocumentProxy("remote_report.pdf", remoteService);

// Client thinks it's calling a local object; proxy handles remote details
remoteDoc.Render();
Console.WriteLine("Content: " + remoteDoc.GetContent());