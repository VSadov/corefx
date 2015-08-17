using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // source of type int Cast to type double
        // DDB: 137558
        public static int Test14()
        {
            try
            {
                int[] source = new int[] { -4, 1, 2, 9 };
                double[] expected = { -4.0, 1.0, 2.0, 9.0 };

                IEnumerable<double> actual = source.Cast<double>();
		Verification.Allequal(actual, expected);
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
            return Test14();
        }
    }
}
