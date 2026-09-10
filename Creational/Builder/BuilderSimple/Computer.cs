using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSimple
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }

        public void DisplaySpecifications()
        {
            Console.WriteLine("Computer Specifications:");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
        }


        public class ComputerBuilder
        {
            private readonly Computer _computer = new();

            public ComputerBuilder SetCPU(string cpu)
            {
                _computer.CPU = cpu;
                return this;
            }

            public ComputerBuilder SetGPU(string gpu)
            {
                _computer.GPU = gpu;
                return this;
            }

            public ComputerBuilder SetRAM(string ram)
            {
                _computer.RAM = ram;
                return this;
            }

            public ComputerBuilder SetStorage(string storage)
            {
                _computer.Storage = storage;
                return this;
            }

            public Computer Build()
            {
                return _computer;
            }
        }
    }
}
