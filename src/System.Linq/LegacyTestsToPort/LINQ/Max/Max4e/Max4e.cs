using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long, maximum value occurs as the last element
        public static int Test4e()
        {
            long?[] source = { null, null, null, null, null, -Int32.MaxValue };
            long? expected = -Int32.MaxValue;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4e();
        }
    }
}
