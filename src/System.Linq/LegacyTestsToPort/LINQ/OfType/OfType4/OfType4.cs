using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        // All elements in source is of type int?
        public static int Test4()
        {
            Object[] source = { 10, -4, null, null, 4, 9 };
            int?[] expected = { 10, -4, 4, 9 };

            IEnumerable<int?> actual = source.OfType<int?>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
