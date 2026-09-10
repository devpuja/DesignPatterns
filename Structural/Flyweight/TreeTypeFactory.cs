namespace Flyweight
{
    public class TreeTypeFactory
    {
        private readonly Dictionary<string, TreeType> _treeTypes = new();

        public TreeType GetTreeType(string name, string texture)
        {
            if (!_treeTypes.TryGetValue(name, out var treeType))
            {
                treeType = new TreeType(name, texture);
                _treeTypes[name] = treeType;
            }

            return treeType;
        }
    }
}