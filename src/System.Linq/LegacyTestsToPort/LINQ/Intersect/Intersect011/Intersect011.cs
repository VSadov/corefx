using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Intersect001()
    {
        var first = from x1 in new int?[] { 2, 3, null, 2, null, 4, 5 }
                    select x1;
        var second = from x2 in new int?[] { 1, 9, null, 4 }
                     select x2;

        var rst1 = first.Intersect(second);
        var rst2 = first.Intersect(second);

        return Verification.Allequal(rst1, rst2);
    }

    static int Intersect002()
    {
        var first = from x1 in new[] { "AAA", String.Empty, "q", "C", "#", "!@#$%^", "0987654321", "Calling Twice"}
                    select x1;
        var second = from x2 in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", "SoS" }
                     select x2;

        var rst1 = first.Intersect(second);
        var rst2 = first.Intersect(second);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(Intersect001) + RunTest(Intersect002);
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
