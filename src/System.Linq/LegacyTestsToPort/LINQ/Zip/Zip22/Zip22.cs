using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // first: last element is null
        public static int Test22()
        {
            IEnumerable<int?> first = new[] { 1, 2, (int?)null };
            IEnumerable<int> second = new int[] { 2, 4, 6, 8 };
            Func<int?, int, int?> func = (x, y) => x + y;
            IEnumerable<int?> expected = new int?[] { 3, 6, null };
            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test22();
        }
    }
}
