using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double, NaN occurs as the last element and the other element is -ve infinity
        public static int Test5k()
        {
            double[] source = { double.NegativeInfinity, double.NaN, };
            double expected = double.NegativeInfinity;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5k();
        }
    }
}
