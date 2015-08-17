using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // first is non-empty and second is empty
        public static int Test3()
        {
            int[] first = { 2, 4, 5, 3, 2, 3, 9 };
            int[] second = { };
            int[] expected = { 2, 4, 5, 3, 9 };

            var actual = first.Union(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
