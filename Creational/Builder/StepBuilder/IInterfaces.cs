namespace StepBuilder
{
    public interface ICpuStep
    {
        IGpuStep SetCPU(string cpu);
    }

    public interface IGpuStep
    {
        IRamStep SetGPU(string gpu);
    }

    public interface IRamStep
    {
        IOptionalStep SetRAM(string ram);
    }

    public interface IOptionalStep
    {
        IOptionalStep SetStorage(string storage);
        Computer Build();
    }
}
