using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double, minimum value occurs as the first element
        public static int Test5d()
        {
            double[] source = { -2.5, 4.9, 130, 4.7, 28 };
            double expected = -2.5;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5d();
        }
    }
}
