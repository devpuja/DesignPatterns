// ========================= 2. Protection Proxy (access control) =========================

namespace Proxy
{
    
    public class User
    {
        public string Name { get; }
        public string Role { get; } //e.g., "Admin", "Editor", "Viewer", etc.

        public User(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }

    
    public class ProtectedDocumentProxy : IDocument
    {
        private readonly IDocument _realDocument;
        private readonly User _currentUser;
        public ProtectedDocumentProxy(IDocument realDocument, User currentUser)
        {
            _realDocument = realDocument;
            _currentUser = currentUser;
        }

        private bool HasAccess()
        {
            // Only allow access to Admins and Editors
            return _currentUser.Role == "Admin" || _currentUser.Role == "Editor";
        }

        public void Render()
        {
            if (!HasAccess())
            {
                Console.WriteLine($"[ProtectionProxy] Access denied for user '{_currentUser.Name}' (role: {_currentUser.Role}).");
                return;
            }

            _realDocument.Render();
        }

        public string GetContent()
        {
            if (!HasAccess())
            {
                Console.WriteLine($"[ProtectionProxy] Access denied for user '{_currentUser.Name}' (role: {_currentUser.Role}).");
                return string.Empty;
            }

            return _realDocument.GetContent();
        }
    }
}
