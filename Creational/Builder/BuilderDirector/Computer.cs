namespace BuilderDirector
{
    internal class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }

        public void DisplaySpecifications()
        {
            Console.WriteLine("BuildDirector > Computer Specifications:");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
        }
    }
}
