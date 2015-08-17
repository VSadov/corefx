using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // second is empty & first has 1 element
        public static int Test11()
        {
            IEnumerable<int> first = new int[] { 1 };
            IEnumerable<int> second = new int[] { };
            Func<int, int, int> func = (x, y) => x + y;
            IEnumerable<int> expected = new int[] { };

            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test11();
        }
    }
}
