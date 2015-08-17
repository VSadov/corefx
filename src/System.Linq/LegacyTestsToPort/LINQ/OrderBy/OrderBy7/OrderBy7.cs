using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderBy
{
    public class Test
    {
        // Overload-2: Elements are in descending order
        public static int Test7()
        {
            int?[] source = { 100, 30, 9, 5, 0, -50, -75, null };
            int?[] expected = { null, -75, -50, 0, 5, 9, 30, 100 };

            var actual = source.OrderBy((e) => e, null);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
