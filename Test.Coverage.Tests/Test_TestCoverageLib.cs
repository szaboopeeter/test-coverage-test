using Test.Coverage.Lib;

namespace Test.Coverage.Tests;

public class Test_TestCoverageLib
{
    [Fact]
    public void TestFunction_WhenBranchFalse_ReturnsTwo()
    {
        var lib = new TestCoverageLib();
        var result = lib.TestFunction(false);
        Assert.Equal(2, result);
    }

    [Fact]
    public void ThrowFunction_WhenBranchFalse_DoesNotThrow()
    {
        var lib = new TestCoverageLib();
        // Just run to see it does not throw.
        lib.ThrowFunction(false);
    }
}