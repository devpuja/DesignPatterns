namespace Memento
{
    public class EditorMemento
    {
        public string Text { get; private set; }
        public EditorMemento(string text)
        {
            Text = text;
        }
    }
}
