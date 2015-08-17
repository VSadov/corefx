using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, NaN occurs as the last element and the other element is -ve infinity
        public static int Test10l()
        {
            float[] source = { float.NegativeInfinity, float.NaN };

            var actual = source.Min();

            return (float.IsNaN(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10l();
        }
    }
}
