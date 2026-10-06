namespace Memento
{
    public class TextEditor
    {
        public string Text { get; private set; } = "";

        public void Write(string text)
        {
            Text += text;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(Text);
        }

        public void Restore(EditorMemento memento)
        {
            Text = memento.Text;
        }
    }
}
