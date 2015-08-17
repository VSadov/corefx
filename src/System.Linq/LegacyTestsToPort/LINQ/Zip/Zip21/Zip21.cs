using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // first: first element is null
        public static int Test21()
        {
            IEnumerable<int?> first = new[] { (int?)null, 2, 3, 4 };
            IEnumerable<int> second = new int[] { 2, 4, 8 };
            Func<int?, int, int?> func = (x, y) => x + y;
            IEnumerable<int?> expected = new int?[] { null, 6, 11 };
            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test21();
        }
    }
}
