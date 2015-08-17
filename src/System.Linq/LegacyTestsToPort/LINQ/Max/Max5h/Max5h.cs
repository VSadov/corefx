using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double, NaN occurs as the 1st element
        public static int Test5h()
        {
            double[] source = { double.NaN, 6.8, 9.4, 10.5, 0, -5.6 };
            double expected = 10.5;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5h();
        }
    }
}
