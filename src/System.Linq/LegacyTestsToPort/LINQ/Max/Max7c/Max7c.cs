using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: decimal, source has all equal values
        public static int Test7c()
        {
            decimal[] source = { -3.4m, -3.4m, -3.4m, -3.4m, -3.4m };
            decimal expected = -3.4m;

            var actual = source.Max();

            return ((expected.Equals(actual)) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7c();
        }
    }
}
