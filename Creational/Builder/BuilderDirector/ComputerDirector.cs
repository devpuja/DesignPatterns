using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDirector
{
    internal class ComputerDirector
    {
        public Computer BuildGamingComputer(IComputerBuilder builder)
        {
            builder.SetCPU("Intel Core i9");
            builder.SetGPU("NVIDIA GeForce RTX 3080");
            builder.SetRAM("32GB DDR4");
            builder.SetStorage("1TB NVMe SSD");
            
            return builder.Build();
        }
    }
}
