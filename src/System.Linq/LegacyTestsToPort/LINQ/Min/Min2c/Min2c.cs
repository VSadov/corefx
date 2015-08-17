using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: int?, source has all null values
        public static int Test2c()
        {
            int?[] source = { null, null, null, null, null };
            int? expected = null;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2c();
        }
    }
}
