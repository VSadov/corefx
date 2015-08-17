using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // Common elements in first and second 
        public static int Test4()
        {
            int[] first = { 1, 2, 3, 4, 5, 6 };
            int[] second = { 6, 7, 7, 7, 8, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };

            var actual = first.Union(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
