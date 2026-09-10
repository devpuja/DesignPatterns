namespace Proxy
{
    // The "real" heavy document (expensive to create)
    public class RealDocument: IDocument
    {
        private readonly string _fileName;
        private readonly string _content;

        public RealDocument(string fileName) 
        {
            _fileName = fileName;

            // Simulate expensive loading (disk, DB, network, etc.)
            Console.WriteLine($"[RealDocument] Loading '{_fileName}' from disk...");
            Thread.Sleep(1500);
            _content = $"Content of {_fileName}";
        }

        public void Render()
        {
            Console.WriteLine($"[RealDocument] Rendering '{_fileName}': {_content}");
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
