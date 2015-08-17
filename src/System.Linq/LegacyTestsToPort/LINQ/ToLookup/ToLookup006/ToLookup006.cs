using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int ToLookup001()
    {
        var q1 = from x1 in new string[] { "Alen", "Felix", null, null, "X", "Have Space", "Clinton", "" }
                 select x1; ;

        var q2 = from x2 in new int[] { 55, 49, 9, -100, 24, 25, -1, 0 }
                 select x2;

        var q = from x3 in q1
                from x4 in q2
                select new { a1 = x3, a2 = x4 };

        var rst1 = q.ToLookup((e) => e.a1);
        var rst2 = q.ToLookup((e) => e.a1);

        return ((null == rst2) ? 1 : 0);
        // return Helper.MatchAll(q1, q2, q);
        // return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(ToLookup001);
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
