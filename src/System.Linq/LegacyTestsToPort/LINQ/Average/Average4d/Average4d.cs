using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: long?, source has different values
        public static int Test4d()
        {
            long?[] source = { 5, -10, null, null, null, 15, 40, 28, null, null };
            double? expected = 15.6;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4d();
        }
    }
}
