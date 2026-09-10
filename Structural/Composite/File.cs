namespace Composite
{
    // Leaf
    internal class Files : IFileSystemItem
    {
        private readonly string _name;
        public Files(string name)
        {
            _name = name;
        }
        public void Display()
        {
            Console.WriteLine($"File: {_name}");
        }
    }
}
