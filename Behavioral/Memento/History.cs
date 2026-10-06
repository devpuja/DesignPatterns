namespace Memento
{
    public class History
    {
        private readonly Stack<EditorMemento> _history = new();

        public void Save(EditorMemento memento)
        {
            _history.Push(memento);
        }

        public EditorMemento Undo()
        {
            if (_history.Count > 0)
            {
                return _history.Pop();
            }
            return null;
        }
    }
}
