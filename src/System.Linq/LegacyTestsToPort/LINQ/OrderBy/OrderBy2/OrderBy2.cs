using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderBy
{
    public class Test
    {
        // Overload-1: keySelector returns null
        public static int Test2()
        {
            int?[] source = { null, null, null };
            int?[] expected = { null, null, null };

            var actual = source.OrderBy((e) => e);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
