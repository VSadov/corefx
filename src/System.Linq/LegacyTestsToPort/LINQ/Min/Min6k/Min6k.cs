using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double?, NaN occurs as the last element and the other element is -ve infinity
        public static int Test6k()
        {
            double?[] source = { double.NegativeInfinity, double.NaN };

            var actual = source.Min();

            return (double.IsNaN((double)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6k();
        }
    }
}
