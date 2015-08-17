using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double, minimum value occurs as the last element
        public static int Test5e()
        {
            double[] source = { 6.8, 9.4, 10, 0, -5.6 };
            double expected = -5.6;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5e();
        }
    }
}
