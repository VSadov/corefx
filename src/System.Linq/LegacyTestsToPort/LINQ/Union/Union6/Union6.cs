using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // first has repeated elements and second has only one element
        public static int Test6()
        {
            int[] first = { 1, 2, 3, 5, 3, 6 };
            int[] second = { 7 };
            int[] expected = { 1, 2, 3, 5, 6, 7 };

            var actual = first.Union(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
