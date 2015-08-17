using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int OrderBy001()
    {
        var q = from x1 in new int[] { 1, 6, 0, -1, 3 }
                from x2 in new int[] { 55, 49, 9, -100, 24, 25 }
                select new { a1 = x1, a2 = x2 };

        var rst1 = q.OrderBy(e => e.a1).ThenBy(f => f.a2);
        var rst2 = q.OrderBy(e => e.a1).ThenBy(f => f.a2);

        return Verification.Allequal(rst1, rst2);
    }

    static int OrderBy002()
    {
        var q = from x1 in new[] { 55, 49, 9, -100, 24, 25, -1, 0 }
                from x2 in new[] { "!@#$%^", "C", "AAA", "", null, "Calling Twice", "SoS", String.Empty }
                where !String.IsNullOrEmpty(x2)
                select new { a1 = x1, a2 = x2 };

        var rst1 = q.OrderBy(e => e.a1);
        var rst2 = q.OrderBy(e => e.a1);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(OrderBy001) + RunTest(OrderBy002);
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
