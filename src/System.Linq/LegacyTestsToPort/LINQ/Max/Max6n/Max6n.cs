using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double?, NaN occurs as the last element and the rest are null's
        public static int Test6n()
        {
            double?[] source = { null, null, null, double.NaN };

            var actual = source.Max();

            return (double.IsNaN((double)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6n();
        }
    }
}
