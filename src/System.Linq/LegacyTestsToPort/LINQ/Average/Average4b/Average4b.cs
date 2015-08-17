using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: long?, source has only one element
        public static int Test4b()
        {
            long?[] source = { Int64.MinValue };
            double? expected = Int64.MinValue;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4b();
        }
    }
}
