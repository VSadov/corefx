using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // second.Count > first.Count > 1
        // second.Count - first.Count == 1
        public static int Test15()
        {
            IEnumerable<int> first = new int[] { 1, 2 };
            IEnumerable<int> second = new int[] { 2, 4, 8 };
            Func<int, int, int> func = (x, y) => x + y;
            IEnumerable<int> expected = new int[] { 3, 6 };

            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test15();
        }
    }
}
