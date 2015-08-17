using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double?, NaN occurs as the 1st element and the sequence includes null
        public static int Test6h()
        {
            double?[] source = { double.NaN, 6.8, 9.4, 10.0, 0.0, null, -5.6 };

            var actual = source.Min();

            return (double.IsNaN((double)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6h();
        }
    }
}
