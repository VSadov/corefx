using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Sum001()
    {
        var q = from x in new int?[] { 9999, 0, 888, -1, 66, null, -777, 1, 2, -12345}
                where x > Int32.MinValue
                select x;

        var rst1 = q.Sum();
        var rst2 = q.Sum();

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int Sum002()
    {
        var q = from x in new[] { 0m, -1M, 1M, 123.456789m, 9999 }
                select x;

        var rst1 = q.Sum();
        var rst2 = q.Sum();

        return ((rst1  == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(Sum001) + RunTest(Sum002);
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
