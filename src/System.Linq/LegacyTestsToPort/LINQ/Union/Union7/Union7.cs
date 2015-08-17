using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // first has only one element and second has all unique elements
        public static int Test7()
        {
            int?[] first = { 2 };
            int?[] second = { 3, null, 4, 5 };
            int?[] expected = { 2, 3, null, 4, 5 };

            var actual = first.Union(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
