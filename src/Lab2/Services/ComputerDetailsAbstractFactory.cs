using Itmo.ObjectOrientedProgramming.Lab2.Entities.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class ComputerDetailsAbstractFactory
{
    private readonly IFactory<CpuBase> _cpuFactory;
    private readonly IFactory<MotherBoard> _motherBoardFactory;
    private readonly IFactory<RamStick> _ramStickFactory;
    private readonly IFactory<WiFiModule> _wifiModuleFactory;

    public ComputerDetailsAbstractFactory(
        IFactory<CpuBase> cpuFactory,
        IFactory<MotherBoard> motherBoardFactory,
        IFactory<RamStick> ramStickFactory,
        IFactory<WiFiModule> wifiModuleFactory)
    {
        _cpuFactory = cpuFactory;
        _motherBoardFactory = motherBoardFactory;
        _ramStickFactory = ramStickFactory;
        _wifiModuleFactory = wifiModuleFactory;
    }

    public CpuBase? GetByName(string cpuName)
    {
        return _cpuFactory.GetByName(cpuName);
    }
}