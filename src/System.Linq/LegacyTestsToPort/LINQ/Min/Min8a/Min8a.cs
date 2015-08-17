using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal?, source is empty, null is returned
        public static int Test8a()
        {
            decimal?[] source = { };
            decimal? expected = null;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8a();
        }
    }
}
