namespace StepBuilder
{
    class Program
    {
        static void Main()
        {
            var computer = Computer.Builder()
                .SetCPU("Intel Core i9")
                .SetGPU("NVIDIA GeForce RTX 3080")
                .SetRAM("32GB DDR4")
                .SetStorage("1TB NVMe SSD")
                .Build();

            Console.WriteLine("Step Builder: \n");
            computer.DisplaySpecifications();
        }
    }
}