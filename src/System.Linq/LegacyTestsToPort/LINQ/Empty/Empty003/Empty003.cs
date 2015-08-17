using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Empty001()
    {
        var rst1 = Enumerable.Empty<int>();
        var rst2 = Enumerable.Empty<int>();

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int Empty002()
    {
        var rst1 = Enumerable.Empty<string>();
        var rst2 = Enumerable.Empty<string>();

        return ((rst1  == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(Empty001) + RunTest(Empty002);
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
