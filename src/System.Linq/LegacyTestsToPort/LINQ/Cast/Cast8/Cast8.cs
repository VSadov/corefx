using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // source of type int? Cast to type long with null value
        // DDB: 137558
        public static int Test8()
        {
            int?[] source = new int?[] { -4, 1, 2, 3, 9 };
            long[] expected = { -4L, 1L, 2L, 3L, 9L };

            try
            {
                IEnumerable<long> actual = source.Cast<long>();
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
            return Test8();
        }
    }
}
