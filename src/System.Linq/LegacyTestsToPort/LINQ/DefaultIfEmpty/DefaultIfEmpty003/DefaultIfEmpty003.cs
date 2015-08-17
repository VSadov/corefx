using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int DefaultIfEmpty001()
    {
        var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345}
                where x > Int32.MinValue
                select x;
 
        var rst1  = q.DefaultIfEmpty(5);
        var rst2  = q.DefaultIfEmpty(5);

        return Verification.Allequal(rst1, rst2);
    }

    static int DefaultIfEmpty002()
    {
        IEnumerable<int> ieInt = Functions.NumList(0, 0);

        var q = from x in ieInt
                select x;

        var rst1  = q.DefaultIfEmpty(88);
        var rst2  = q.DefaultIfEmpty(88);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(DefaultIfEmpty001) + RunTest(DefaultIfEmpty002);
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
