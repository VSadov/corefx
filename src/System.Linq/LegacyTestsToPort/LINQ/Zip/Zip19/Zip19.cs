using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // func is changed - delegate
        public static int Test19()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3, 4 };
            IEnumerable<int> second = new int[] { 2, 4, 8 };
            Func<int, int, int> func = (x, y) => x + y;
            IEnumerable<int> expected = new int[] { 3, 6, 11 };
            var actual = first.Zip(second, func);
            if (Verification.Allequal(expected, actual) != 0)
                return 1;
            func = (x, y) => x - y;
            expected = new int[] { -1, -2, -5 };
            actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test19();
        }
    }
}
