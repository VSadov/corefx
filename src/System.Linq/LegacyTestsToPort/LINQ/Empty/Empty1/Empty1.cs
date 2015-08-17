using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Empty
{
    public class Test
    {
        // Type: Empty Sequence of int
        public static int Test1()
        {
            int[] expected = {};

            IEnumerable<int> actual = Enumerable.Empty<int>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
