using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal, minimum value occurs as the first element
        public static int Test7d()
        {
            decimal[] source = { -2.5m, 4.9m, 130m, 4.7m, 28m };
            decimal expected = -2.5m;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7d();
        }
    }
}
