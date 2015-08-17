using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // first.Count == second.Count == 1
        public static int Test13()
        {
            IEnumerable<int> first = new int[] { 1 };
            IEnumerable<int> second = new int[] { 2 };
            Func<int, int, int> func = (x, y) => x + y;
            IEnumerable<int> expected = new int[] { 3 };

            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test13();
        }
    }
}
