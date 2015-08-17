using System;
using System.Collections.Generic;
using System.Linq;

public class TestCase
{
    static int Cast001()
    {
        try
        {
            var q = from x in new[] { 9999, 0, 888, -1, 66, -777, 1, 2, -12345 }
                    where x > Int32.MinValue
                    select x;

            var rst1 = q.Cast<long>();
            var rst2 = q.Cast<long>();

	    Verification.Allequal(rst1, rst2);
        }
        catch (InvalidCastException)
        {
            return 0;
        }
        catch (Exception) { return 1; }
        return 1;
    }

    static int Cast002()
    {
        try
        {
            var q = from x in new byte[] { 0, 255, 127, 128, 1, 33, 99 }
                    select x;

            var rst1 = q.Cast<ushort>();
            var rst2 = q.Cast<ushort>();
	    Verification.Allequal(rst1, rst2);
        }
        catch (InvalidCastException)
        {
            return 0;
        }
        catch (Exception) { return 1; }
        return 1;
    }

    public static int Main()
    {
        int ret = RunTest(Cast001) + RunTest(Cast002);
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
