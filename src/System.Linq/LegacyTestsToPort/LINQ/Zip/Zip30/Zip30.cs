using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // all elements in first and second are null
        // first.Count == second.Count
        public static int Test30()
        {
            IEnumerable<int?> first = new int?[] { null, null, null };
            IEnumerable<int?> second = new int?[] { null, null, null };
            Func<int?, int?, int?> func = (x, y) => x + y;
            IEnumerable<int?> expected = new int?[] { null, null, null };
            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test30();
        }
    }
}
