using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: int, minimum value occurs as the last element
        public static int Test2e()
        {
            int?[] source = { null, null, null, null, null, -5 };
            int? expected = -5;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2e();
        }
    }
}
