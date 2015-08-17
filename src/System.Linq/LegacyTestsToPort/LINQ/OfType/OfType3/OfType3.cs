using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        // only the first element in source is of type int
        public static int Test3()
        {
            Object[] source = { 10, "Hello", 3.5, "Test" };
            int[] expected = { 10 };

            IEnumerable<int> actual = source.OfType<int>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
