using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDirector
{
    internal class GamingComputerBuilder : IComputerBuilder
    {
        private readonly Computer _computer = new Computer();

        public void SetCPU(string cpu)
        {
            _computer.CPU = cpu;
        }

        public void SetGPU(string gpu)
        {
            _computer.GPU = gpu;
        }

        public void SetRAM(string ram)
        {
            _computer.RAM = ram;
        }

        public void SetStorage(string storage)
        {
            _computer.Storage = storage;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
