namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public interface IFactory<T>
{
    T? GetByName(string name);
}