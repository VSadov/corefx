using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Single001()
    {
        var q = from x in new[] { 999.9m}
                select x;
 
        var rst1  = q.Single();
        var rst2  = q.Single();

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int Single002()
    {
        var q = from x in new[] { "!@#$%^" }
                where !String.IsNullOrEmpty(x)
                select x;

        var rst1  = q.Single<string>();
        var rst2  = q.Single<string>();

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int Single003()
    {
        var q = from x in new[] { 0 }
                select x;

        var rst1 = q.Single();
        var rst2 = q.Single();

        return ((rst1 == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(Single001) + RunTest(Single002) + RunTest(Single003);
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
