using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double, source element has only NaN's
        public static int Test5l()
        {
            double[] source = { double.NaN, double.NaN, double.NaN };

            var actual = source.Min();

            return (double.IsNaN(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5l();
        }
    }
}
