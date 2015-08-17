using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{

    static int Any001()
    {
        var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345}
                where x > Int32.MinValue
                select x;
 
        Func<int, bool> predicate = Functions.IsEven;
        var rst1  = q.Any(predicate);
        var rst2  = q.Any(predicate);

        return ((rst1  == rst2) ? 0 : 1);
    }

    static int Any002()
    {
        var q = from x in new[] { "!@#$%^", "C", "AAA", "", "Calling Twice", "SoS", String.Empty }
                select x;

        Func<string, bool> predicate = Functions.IsEmpty;
        var rst1  = q.Any<string>(predicate);
        var rst2  = q.Any<string>(predicate);

        return ((rst1  == rst2) ? 0 : 1);
    }

    public static int Main()
    {
        int ret = RunTest(Any001) + RunTest(Any002);
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
