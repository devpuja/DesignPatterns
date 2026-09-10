using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDirector
{
    internal interface IComputerBuilder
    {
        void SetCPU(string cpu);
        void SetGPU(string gpu);
        void SetRAM(string ram);
        void SetStorage(string storage);

        Computer Build();
    }
}
