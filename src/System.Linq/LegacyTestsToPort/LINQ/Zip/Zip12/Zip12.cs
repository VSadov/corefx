using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // second is empty & first has over 1 elements
        public static int Test12()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3 };
            IEnumerable<int> second = new int[] { };
            Func<int, int, int> func = (x, y) => x + y;
            IEnumerable<int> expected = new int[] { };

            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test12();
        }
    }
}
