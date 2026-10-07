namespace TemplateMethod
{
    public class PdfProcessor : DocumentProcessor
    {
        protected override void Open()
        {
            Console.WriteLine("Opening PDF Document.");
        }
        protected override void Read()
        {
            Console.WriteLine("Reading PDF Document.");
        }
        protected override void Process()
        {
            Console.WriteLine("Processing PDF Document.");
        }
    }
}
