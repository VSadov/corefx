using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int ThenByDescending001()
    {
        var q = from x1 in new int[] { 1, 6, 0, -1, 3 }
                from x2 in new int[] { 55, 49, 9, -100, 24, 25 }
                select new { a1 = x1, a2 = x2 };

        var rst1 = q.OrderByDescending(e => e.a2).ThenByDescending(f => f.a1);
        var rst2 = q.OrderByDescending(e => e.a2).ThenByDescending(f => f.a1);

        return Verification.Allequal(rst1, rst2);
    }

    static int ThenByDescending002()
    {
        var q = from x1 in new[] { 55, 49, 9, -100, 24, 25, -1, 0 }
                from x2 in new[] { "!@#$%^", "C", "AAA", "", null, "Calling Twice", "SoS", String.Empty }
                where !String.IsNullOrEmpty(x2)
                select new { a1 = x1, a2 = x2 };

        var rst1 = q.OrderBy(e => e.a1).ThenByDescending(f => f.a2);
        var rst2 = q.OrderBy(e => e.a1).ThenByDescending(f => f.a2);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(ThenByDescending001) + RunTest(ThenByDescending002);
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
