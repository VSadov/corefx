using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // first is empty and second is non-empty
        public static int Test2()
        {
            int[] first = { };
            int[] second = { 2, 4, 5, 3, 2, 3, 9 };
            int[] expected = { 2, 4, 5, 3, 9 };

            var actual = first.Union(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
