using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Max001()
    {
        var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345}
                where x > Int32.MinValue
                select x;

        var rst1 = q.Max();
        var rst2 = q.Max();

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int Max002()
    {
        var q = from x in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", "SoS", String.Empty }
                where !String.IsNullOrEmpty(x)
                select x;

        var rst1 = q.Max<string>();
        var rst2 = q.Max<string>();

        return ((rst1 == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(Max001) + RunTest(Max002);
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
