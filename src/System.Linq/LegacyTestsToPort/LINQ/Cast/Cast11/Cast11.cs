using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // source of type int? to object and IEnumerable<int?> Cast to type long?
        // DDB: 137558
        public static int Test11()
        {
            try
            {
                int? i = 10;
                Object[] source = { -4, 1, 2, 3, 9, null, i };
                long?[] expected = { -4L, 1L, 2L, 3L, 9L, null, (long?)i };

                IEnumerable<int?> source1 = source.Cast<int?>();
                IEnumerable<long?> actual = source1.Cast<long?>();
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
            return Test11();
        }
    }
}
