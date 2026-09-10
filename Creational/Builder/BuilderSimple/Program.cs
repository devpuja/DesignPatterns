using BuilderSimple;

namespace BuilderSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Builder Example! \n");
            var computerBuilder = new Computer.ComputerBuilder()
                .SetCPU("Intel Core i9")
                .SetRAM("32GB")
                .SetGPU("NVIDIA GeForce RTX 3080")
                .SetStorage("1TB SSD")
                .Build();

            computerBuilder.DisplaySpecifications();
        }
    }
}
