using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: long?, source has all null values
        public static int Test4c()
        {
            long?[] source = { null, null, null, null, null };
            long? expected = null;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4c();
        }
    }
}
