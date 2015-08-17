using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Concat
{
    public class Test
    {
        // first is non-empty and second is non-empty
        public static int Test4()
        {
            int?[] first = { 2, null, 3, 5, 9 };
            int?[] second = { null, 8, 10 };
            int?[] expected = { 2, null, 3, 5, 9, null, 8, 10 };

            var actual = first.Concat(second);
            return Verification.Allequal(expected, actual);
        }

        public static int Main(string[] args)
        {
            return Test4();
        }
    }
}
