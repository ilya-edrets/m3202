using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Tests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Test1(int a)
    {
        var result = a * a;

        Assert.Positive(result);
        Assert.GreaterThan(result, a);
    }
}