using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // first has repeated elements, second has elements not in first
        public static int Test5()
        {
            int[] first = { 1, 1, 1, 1, 1 };
            int[] second = { 2, 3, 4 };
            int[] expected = { 1 };

            var actual = first.Except(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
