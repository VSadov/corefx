using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double?, NaN occurs as the 1st element and the other element is -ve infinity
        public static int Test6j()
        {
            double?[] source = { double.NaN, double.NegativeInfinity };

            var actual = source.Min();

            return (double.IsNaN((double)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6j();
        }
    }
}
