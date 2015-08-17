using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        // When 2nd, 5th and the last element is of type int
        public static int Test5()
        {
            Object[] source = { 3.5m, -4, "Test", "Check", 4, 8.0, 10.5, 9 };
            int[] expected = { -4, 4, 9 };

            IEnumerable<int> actual = source.OfType<int>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
