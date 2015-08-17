using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int SequenceEqual001()
    {
        var q1 = from x1 in new int?[] { 2, 3, null, 2, null, 4, 5 }
                 select x1;
        var q2 = from x2 in new int?[] { 1, 9, null, 4 }
                 select x2;
 
        var rst1 = q1.SequenceEqual(q2);
        var rst2 = q1.SequenceEqual(q2);

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int SequenceEqual002()
    {
        var q1 = from x1 in new[] { "AAA", String.Empty, "q", "C", "#", "!@#$%^", "0987654321", "Calling Twice" }
                 select x1;
        var q2 = from x2 in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", "SoS" }
                 select x2;

        var rst1 = q1.SequenceEqual(q2);
        var rst2 = q1.SequenceEqual(q2);

        return ((rst1  == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(SequenceEqual001) + RunTest(SequenceEqual002);
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
