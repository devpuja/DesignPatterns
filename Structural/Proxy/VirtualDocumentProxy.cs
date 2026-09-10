
// ========================= 1. Virtual Proxy (lazy load) =========================

namespace Proxy
{
    public class VirtualDocumentProxy : IDocument
    {
        private readonly string _fileName;
        private RealDocument? _realDocument;

        public VirtualDocumentProxy(string fileName)
        {
            _fileName = fileName;
            // Note: RealDocument is NOT created here
        }

        public void Render()
        {
            if (_realDocument == null)
            {
                _realDocument = new RealDocument(_fileName);
            }

            _realDocument.Render();
        }

        public string GetContent()
        {
            if (_realDocument == null)
            {
                _realDocument = new RealDocument(_fileName);
            }

            return _realDocument.GetContent();
        }
    }

}