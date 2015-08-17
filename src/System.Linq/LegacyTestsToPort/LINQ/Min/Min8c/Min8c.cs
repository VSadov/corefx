using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal?, source has all null values
        public static int Test8c()
        {
            decimal?[] source = { null, null, null, null, null };
            decimal? expected = null;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8c();
        }
    }
}
