using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, NaN occurs as the 1st element and the sequence includes null
        public static int Test11i()
        {
            float?[] source = { float.NaN, 6.8f, 9.4f, 10f, 0, null, -5.6f };

            var actual = source.Min();

            return (float.IsNaN((float)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11i();
        }
    }
}
