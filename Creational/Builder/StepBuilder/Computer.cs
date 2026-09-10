namespace StepBuilder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }

        internal Computer(string cpu, string gpu, string ram, string storage)
        {
            CPU = cpu;
            GPU = gpu;
            RAM = ram;
            Storage = storage;
        }

        public static ICpuStep Builder()
        {
            return new ComputerBuilder();
        }

        public void DisplaySpecifications()
        {
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
        }
    }
}
