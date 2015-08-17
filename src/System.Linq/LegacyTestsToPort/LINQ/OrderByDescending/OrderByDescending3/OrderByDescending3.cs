using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByDescending
{
    public class Test
    {
        // Overload-1: All elements have the same key
        public static int Test3()
        {
            int?[] source = { 9, 9, 9, 9, 9, 9 };
            int?[] expected = { 9, 9, 9, 9, 9, 9 };

            var actual = source.OrderByDescending((e) => e);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
