using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: decimal, source has limited number of elements
        public static int Test7c()
        {
            decimal[] source = { 20.45m, 0, -10.55m, 5.55m };
            decimal expected = 15.45m;

            var actual = source.Sum();

            return (expected.Equals(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7c();
        }
    }
}
