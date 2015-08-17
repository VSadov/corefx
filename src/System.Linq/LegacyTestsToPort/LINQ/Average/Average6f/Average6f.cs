using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double?, source has all null values
        public static int Test6f()
        {
            double?[] source = { null, null, null, null, null };
            double? expected = null;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6f();
        }
    }
}
