using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Distinct001()
    {
        var q = from x in new[] { 0, 9999, 0, 888, -1, 66, -1, -777, 1, 2, -12345, 66, 66, -1, -1}
                where x > Int32.MinValue
                select x;

        var rst1 = q.Distinct();
        var rst2 = q.Distinct();

        return Verification.Allequal(rst1, rst2);
    }

    static int Distinct002()
    {
        var q = from x in new[] { "!@#$%^", "C", "AAA", "Calling Twice", "SoS" }
                where String.IsNullOrEmpty(x)
                select x;

        var rst1 = q.Distinct();
        var rst2 = q.Distinct();

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(Distinct001) + RunTest(Distinct002);
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
