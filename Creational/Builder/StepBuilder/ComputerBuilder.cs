namespace StepBuilder
{
    internal class ComputerBuilder : ICpuStep, IGpuStep, IRamStep, IOptionalStep
    {
        private string _cpu;
        private string _gpu;
        private string _ram;
        private string _storage;
        
        
        public IGpuStep SetCPU(string cpu)
        {
            _cpu = cpu;
            return this;
        }
        public IRamStep SetGPU(string gpu)
        {
            _gpu = gpu;
            return this;
        }
        public IOptionalStep SetRAM(string ram)
        {
            _ram = ram;
            return this;
        }
        public IOptionalStep SetStorage(string storage)
        {
            _storage = storage;
            return this;
        }

        public Computer Build()
        {
            return new Computer(_cpu, _gpu, _ram, _storage);
        }
    }
}
