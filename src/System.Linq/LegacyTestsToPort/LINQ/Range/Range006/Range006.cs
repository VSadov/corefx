using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Range001()
    {
        var rst1 = Enumerable.Range(-1, 2);
        var rst2 = Enumerable.Range(-1, 2);

        return Verification.Allequal(rst1, rst2);
    }

    static int Range002()
    {
        var rst1 = Enumerable.Range(0, 0);
        var rst2 = Enumerable.Range(0, 0);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(Range001) + RunTest(Range002);
        if (0 != ret)
            Console.Write(errorMessage);

        return ret;
    }

    static string errorMessage = String.Empty;
    delegate int D();

    private static int RunTest(D m)
    {
        int n = m();
        if (0 != n)
            errorMessage += m.ToString() + " - FAILED!\r\n";
        return n;
    }
}
