namespace Flyweight
{
    public class Tree
    {
        private int _x; private int _y;
        private readonly TreeType _treeType;
        
        public Tree(int x, int y, TreeType treeType)
        {
            _x = x;
            _y = y;
            _treeType = treeType;
        }

        public void Display()
        {
            _treeType.Display(_x, _y);
        }
    }
}