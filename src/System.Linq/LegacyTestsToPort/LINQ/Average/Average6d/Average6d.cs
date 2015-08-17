using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double?, source has different values
        public static int Test6d()
        {
            double?[] source = { 5.5, 0, null, null, null, 15.5, 40.5, null, null, -23.5 };
            double? expected = 7.6;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6d();
        }
    }
}
