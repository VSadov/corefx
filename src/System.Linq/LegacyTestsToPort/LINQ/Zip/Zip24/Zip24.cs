using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // first - all elements are null
        public static int Test24()
        {
            IEnumerable<int?> first = new int?[] { null, null, null };
            IEnumerable<int> second = new int[] { 2, 4, 6, 8 };
            Func<int?, int, int?> func = (x, y) => x + y;
            IEnumerable<int?> expected = new int?[] { null, null, null };
            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test24();
        }
    }
}
