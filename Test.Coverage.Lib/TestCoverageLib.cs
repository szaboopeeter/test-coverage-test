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
}
