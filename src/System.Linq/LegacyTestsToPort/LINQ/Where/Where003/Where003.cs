using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Where001()
    {
        var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345}
                where x > Int32.MinValue
                select x;

        Func<int, bool> predicate = Functions.IsEven;
        var rst1 = q.Where(predicate);
        var rst2 = q.Where(predicate);

        return Verification.Allequal(rst1, rst2);
    }

    static int Where002()
    {
        var q = from x in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", null, "SoS", String.Empty }
                select x;

        Func<string, bool> predicate = Functions.IsEmpty;

        var rst1 = q.Where(predicate);
        var rst2 = q.Where(predicate);

        return Verification.Allequal(rst1, rst2);
    }

    public static int Main()
    {
        int ret = RunTest(Where001) + RunTest(Where002);
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
