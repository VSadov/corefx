using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal?, source is empty
        public static int Test8a()
        {
            decimal?[] source = { };
            decimal? expected = null;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8a();
        }
    }
}
