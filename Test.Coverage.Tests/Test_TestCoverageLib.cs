using Test.Coverage.Lib;

namespace Test.Coverage.Tests;

public class Test_TestCoverageLib
{
    [Fact]
    public void TestFunction_WhenBranch_ReturnsTrue()
    {
        var lib = new TestCoverageLib();
        var result = lib.TestFunction(true);
        Assert.Equal(1, result);
    }
}
