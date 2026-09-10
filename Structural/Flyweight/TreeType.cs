namespace Flyweight
{
    public class TreeType
    {
        public string Name { get; set; }
        public string Texture { get; set; }

        public TreeType(string name, string texture)
        {
            Name = name;
            Texture = texture;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Displaying {Name} tree with texture {Texture} at ({x}, {y})");
        }
    }
}