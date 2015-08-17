using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByDescending
{
    public class Test
    {
        // Overload-1: source is empty
        public static int Test1()
        {
            int[] source = { };
            int[] expected = { };

            var actual = source.OrderByDescending((e) => e);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
