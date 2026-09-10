using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    // Composite 
    internal class Folder : IFileSystemItem
    {
        private readonly string _name;
        private readonly List<IFileSystemItem> _items = new();
        public Folder(string name)
        {
            _name = name;
        }
        public void Add(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Remove(IFileSystemItem item)
        {
            _items.Remove(item);
        }

        public void Display()
        {
            Console.WriteLine($"Folder: {_name}");
            foreach (var item in _items)
            {
                item.Display();
            }
        }
    }
}
