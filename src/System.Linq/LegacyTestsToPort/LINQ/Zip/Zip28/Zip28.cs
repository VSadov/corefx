using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // second - all elements are null
        public static int Test28()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3, 4 };
            IEnumerable<int?> second = new int?[] { null, null, null };
            Func<int, int?, int?> func = (x, y) => x + y;
            IEnumerable<int?> expected = new int?[] { null, null, null };
            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test28();
        }
    }
}
