using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: long, Minimum occurs as the first element
        public static int Test4d()
        {
            long?[] source = { Int64.MinValue, null, 9, 10, null, 7, 8 };
            long? expected = Int64.MinValue;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4d();
        }
    }
}
