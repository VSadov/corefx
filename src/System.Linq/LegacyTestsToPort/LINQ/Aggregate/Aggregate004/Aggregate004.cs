using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{

    public static int Accumulate(int e1, int e2)
    {
        return e1 + e2;
    }

    public static string Accumulate(string s1, string s2)
    {
        return s1 + s2;
    }

    static int Aggregate001()
    {
        var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345 }
                where x > Int32.MinValue
                select x;

        var rst1 = q.Aggregate(Accumulate);
        var rst2 = q.Aggregate(Accumulate);
        return ((rst1 == rst2) ? 0 : 1);
    }

    static int Aggregate002()
    {
        var q = from x in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", "SoS", String.Empty }
                where !String.IsNullOrEmpty(x)
                select x;

        var rst1 = q.Aggregate(Accumulate);
        var rst2 = q.Aggregate(Accumulate);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(Aggregate001) + RunTest(Aggregate002);
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
