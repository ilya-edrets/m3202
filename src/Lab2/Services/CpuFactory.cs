using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class CpuFactory : IFactory<CpuBase>
{
    private List<CpuBase> _cpuList = new List<CpuBase>();

    // protected CpuFactory()
    // {
    //     cpuList.Add(new LGA1677Cpu { Name = "Intel i7 13600H" });
    //     cpuList.Add(new LGA1677Cpu { Name = "Intel i7 13600H" });
    //     cpuList.Add(new LGA1677Cpu { Name = "Intel i7 13600H" });
    //     cpuList.Add(new LGA1677Cpu { Name = "Intel i7 13600H" });
    //     cpuList.Add(new LGA1677Cpu { Name = "Intel i7 13600H" });
    //     cpuList.Add(new LGA1677Cpu { Name = "Intel i7 13600H" });
    // }

    public CpuFactory(List<CpuBase> cpuList)
    {
        _cpuList = cpuList;
    }

    public CpuBase? GetByName(string cpuName)
    {
        return _cpuList.FirstOrDefault(x => x.Name.Equals(cpuName, StringComparison.OrdinalIgnoreCase));
    }
}