using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long, Maximum occurs as the first element
        public static int Test4d()
        {
            long?[] source = { Int64.MaxValue, null, 9, 10, null, 7, 8 };
            long? expected = Int64.MaxValue;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4d();
        }
    }
}
