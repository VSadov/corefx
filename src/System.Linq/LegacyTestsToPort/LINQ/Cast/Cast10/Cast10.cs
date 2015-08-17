using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // source of type int? to object and IEnumerable<int?> Cast to type long
        // DDB: 137558
        public static int Test10()
        {
            int? i = 10;
            Object[] source = { -4, 1, 2, 3, 9, i };

            long[] expected = { -4L, 1L, 2L, 3L, 9L, (long)i };

            try
            {
                IEnumerable<int?> source1 = source.Cast<int?>();
                IEnumerable<long> actual = source1.Cast<long>();
                Verification.Allequal(expected, actual);
                return 1;
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test10();
        }
    }
}
