using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
        static int Average001()
    {
        var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345}
                where x > Int32.MinValue
                select x;

        var rst1 = q.Average();
        var rst2 = q.Average();

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int Average002()
    {
        var q = from x in new long?[] { Int32.MaxValue, 0, 255, 127, 128, 1, 33, 99, null, Int32.MinValue }
                select x;

        var rst1 = q.Average();
        var rst2 = q.Average();

        return ((rst1  == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(Average001) + RunTest(Average002);
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
