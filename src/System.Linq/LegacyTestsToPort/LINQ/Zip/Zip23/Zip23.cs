using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // first - middle element is null value
        public static int Test23()
        {
            IEnumerable<int?> first = new[] { 1, (int?)null, 3 };
            IEnumerable<int> second = new int[] { 2, 4, 6, 8 };
            Func<int?, int, int?> func = (x, y) => x + y;
            IEnumerable<int?> expected = new int?[] { 3, null, 9 };
            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test23();
        }
    }
}
