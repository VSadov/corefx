using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: long, minimum value occurs as the last element
        public static int Test4e()
        {
            long?[] source = { null, null, null, null, null, -Int32.MaxValue };
            long? expected = -Int32.MaxValue;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4e();
        }
    }
}
