using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Repeat001()
    {
        var rst1 = Enumerable.Repeat(-3, 0);
        var rst2 = Enumerable.Repeat(-3, 0);

        return Verification.Allequal(rst1, rst2);
    }

    static int Repeat002()
    {
        var rst1 = Enumerable.Repeat("SSS", 99);
        var rst2 = Enumerable.Repeat("SSS", 99);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(Repeat001) + RunTest(Repeat002);
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
