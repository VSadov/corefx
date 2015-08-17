using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // func is changed - lambda expression
        public static int Test20()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3, 4 };
            IEnumerable<int> second = new int[] { 2, 4, 8 };            
            IEnumerable<int> expected = new int[] { 3, 6, 11 };
            var actual = first.Zip(second, (x, y) => x + y);

            if (Verification.Allequal(expected, actual) != 0)
                return 1;

            expected = new int[] { -1, -2, -5 };
            actual = first.Zip(second, (x, y) => x - y);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test20();
        }
    }
}
