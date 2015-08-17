using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // first is empty & second has 1 elment
        public static int Test9()
        {
            IEnumerable<int> first = new int[] { };
            IEnumerable<int> second = new int[] { 2 };
            Func<int, int, int> func = (x, y) => x + y;
            IEnumerable<int> expected = new int[] { };

            var actual = first.Zip(second, func);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test9();
        }
    }
}
