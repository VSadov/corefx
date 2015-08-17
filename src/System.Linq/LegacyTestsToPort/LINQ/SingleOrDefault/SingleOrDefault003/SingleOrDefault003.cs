using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int SingleOrDefault001()
    {
        var q = from x in new[] { 0.12335f }
                select x;

        var rst1  = q.SingleOrDefault();
        var rst2  = q.SingleOrDefault();

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int SingleOrDefault002()
    {
        var q = from x in new[] { "" }
                select x;

        Func<string, bool> predicate = Functions.IsEmpty;
        var rst1 = q.SingleOrDefault(predicate);
        var rst2 = q.SingleOrDefault(predicate);

        return ((rst1  == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(SingleOrDefault001) + RunTest(SingleOrDefault002);
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
