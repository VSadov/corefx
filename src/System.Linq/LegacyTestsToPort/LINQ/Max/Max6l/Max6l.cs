using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double?, source element has only NaN's
        public static int Test6l()
        {
            double?[] source = { double.NaN, double.NaN, double.NaN };

            var actual = source.Max();

            return (double.IsNaN((double)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6l();
        }
    }
}
