using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // second - middle element is null
        public static int Test27()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3, 4 };
            IEnumerable<int?> second = new int?[] { 2, null, 6 };
            Func<int, int?, int?> func = (x, y) => x + y;
            IEnumerable<int?> expected = new int?[] { 3, null, 9 };
            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test27();
        }
    }
}
