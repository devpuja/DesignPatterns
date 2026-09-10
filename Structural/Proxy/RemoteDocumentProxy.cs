// ========================= 3. Remote Proxy (network boundary) =========================

namespace Proxy
{
    public class RemoteDocumentService
    {
        public IDocument GetDocument(string fileName)
        {
            // Simulate a network call to fetch the document
            Console.WriteLine($"[RemoteDocumentService] Fetching '{fileName}' from remote server...");
            Thread.Sleep(1000); // Simulate network latency
            return new RealDocument(fileName);
        }
    }


    public class RemoteDocumentProxy : IDocument
    {
        private readonly string _fileName;
        private readonly RemoteDocumentService _remoteService;
        private IDocument? _remoteDocument;

        public RemoteDocumentProxy(string fileName, RemoteDocumentService remoteService)
        {
            _fileName = fileName;
            _remoteService = remoteService;
        }

        public void Render()
        {
            var doc = GetRemoteDocument();
            Console.WriteLine("[RemoteProxy] Calling remote Render()...");
            Thread.Sleep(500); // Simulate network latency
            doc.Render();
        }

        public string GetContent()
        {
            var doc = GetRemoteDocument();
            Console.WriteLine("[RemoteProxy] Calling remote GetContent()...");
            Thread.Sleep(500); // Simulate network latency
            return doc.GetContent();
        }

        private IDocument GetRemoteDocument()
        {
            // In a real remote proxy, this would be an RPC / gRPC / WCF / REST call.
            // Here we just call into a service object to simulate it.
            if (_remoteDocument == null)
            {
                Console.WriteLine("[RemoteProxy] Fetching document from remote service...");
                _remoteDocument = _remoteService.GetDocument(_fileName);
            }

            return _remoteDocument;
        }
    }
}
