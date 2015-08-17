using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: int?, source has all null values
        public static int Test2f()
        {
            int?[] source = { null, null, null, null, null };
            double? expected = null;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2f();
        }
    }
}
