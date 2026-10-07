namespace TemplateMethod
{
    public abstract class DocumentProcessor
    {
        protected abstract void Open();
        protected abstract void Read();
        protected abstract void Process();

        protected virtual void Close()
        {
            Console.WriteLine("Closing Document.");
        }

        public void ProcessDocument()
        {
            Open();
            Read();
            Process();
            Close();
        }

    }
}
