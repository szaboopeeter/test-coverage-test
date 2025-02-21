namespace Test.Coverage.Lib;

public class TestCoverageLib
{
    public int TestFunction(bool branch)
    {
        if (branch)
        {
            return 1;
        }

        return 2;
    }

    public void ThrowFunction(bool shouldThrow)
    {
        if (shouldThrow) { throw new NotImplementedException(); }
    }

    public int TernaryFunction(bool branch)
    {
        return branch ? 1 : 2;
    }
}