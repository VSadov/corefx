using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // All elements in source can be cast to int?
        public static int Test4()
        {
            Object[] source = { 3, null, 5, -4, 0, null, 9 };
            int?[] expected = { 3, null, 5, -4, 0, null, 9 };

            IEnumerable<int?> actual = source.Cast<int?>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
