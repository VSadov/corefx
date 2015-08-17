using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double?, NaN occurs as the first element and the rest are null's
        public static int Test6m()
        {
            double?[] source = { double.NaN, null, null, null };

            var actual = source.Max();

            return (double.IsNaN((double)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6m();
        }
    }
}
