using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // second - first element is null
        public static int Test25()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3, 4 };
            IEnumerable<int?> second = new int?[] { null, 4, 6 };
            Func<int, int?, int?> func = (x, y) => x + y;
            IEnumerable<int?> expected = new int?[] { null, 6, 9 };
            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test25();
        }
    }
}
