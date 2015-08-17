using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal?, source has different values
        public static int Test8d()
        {
            decimal?[] source = { 5.5m, 0, null, null, null, 15.5m, 40.5m, null, null, -23.5m };
            decimal? expected = 7.6m;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8d();
        }
    }
}
