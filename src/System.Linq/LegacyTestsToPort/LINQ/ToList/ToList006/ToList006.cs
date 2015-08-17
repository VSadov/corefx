using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int ToList001()
    {
        var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345}
                where x > Int32.MinValue
                select x;
 
        var rst1  = q.ToList<int>();
        var rst2  = q.ToList<int>();

        return Verification.Allequal(rst1, rst2);
    }

    static int ToList002()
    {
        var q = from x in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", "SoS", String.Empty }
                where !String.IsNullOrEmpty(x)
                select x;

        var rst1  = q.ToList<string>();
        var rst2  = q.ToList<string>();

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(ToList001) + RunTest(ToList002);
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
