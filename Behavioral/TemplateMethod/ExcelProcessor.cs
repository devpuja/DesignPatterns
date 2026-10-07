namespace TemplateMethod
{
    public class ExcelProcessor : DocumentProcessor
    {
        protected override void Open()
        {
            Console.WriteLine("Opening Excel Document.");
        }
        protected override void Read()
        {
            Console.WriteLine("Reading Excel Document.");
        }
        protected override void Process()
        {
            Console.WriteLine("Processing Excel Document.");
        }
    }
}
