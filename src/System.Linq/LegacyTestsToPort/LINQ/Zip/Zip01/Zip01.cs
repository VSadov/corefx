using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // implicit type parameters
        public static int Test1()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3 };
            IEnumerable<int> second = new int[] { 2, 5, 9 };
            IEnumerable<int> expected = new int[] { 3, 7, 12 };

            var actual = first.Zip(second, (x, y) => x + y);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
