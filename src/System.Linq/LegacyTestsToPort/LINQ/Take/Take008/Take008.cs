using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Take001()
    {
        var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345}
                where x > Int32.MinValue
                select x;
 
        var rst1  = q.Take(9);
        var rst2  = q.Take(9);

        return Verification.Allequal(rst1, rst2);
    }

    static int Take002()
    {
        var q = from x in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", "SoS", String.Empty }
                where !String.IsNullOrEmpty(x)
                select x;

        var rst1  = q.Take(7);
        var rst2  = q.Take(7);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(Take001) + RunTest(Take002);
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
