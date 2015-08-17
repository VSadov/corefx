using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        // source does NOT have any object of type int
        public static int Test2()
        {
            Object[] source = { "Hello", 3.5, "Test" };
            int[] expected = { };

            IEnumerable<int> actual = source.OfType<int>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
