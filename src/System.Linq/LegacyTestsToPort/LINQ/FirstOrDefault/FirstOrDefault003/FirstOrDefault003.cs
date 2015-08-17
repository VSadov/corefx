using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int FirstOrDefault001()
    {
        IEnumerable<int> ieInt = Functions.NumList(0, 0);
        var q = from x in ieInt
                select x;
 
        var rst1  = q.FirstOrDefault();
        var rst2  = q.FirstOrDefault();

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int FirstOrDefault002()
    {
        var q = from x in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", "SoS", String.Empty }
                where !String.IsNullOrEmpty(x)
                select x;

        var rst1  = q.FirstOrDefault();
        var rst2  = q.FirstOrDefault();

        return ((rst1  == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(FirstOrDefault001) + RunTest(FirstOrDefault002);
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
