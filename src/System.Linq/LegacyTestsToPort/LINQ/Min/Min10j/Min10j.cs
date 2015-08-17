using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, NaN occurs as the last element
        public static int Test10j()
        {
            float[] source = { 6.8f, 9.4f, 10f, 0, -5.6f, float.NaN };

            var actual = source.Min();

            return (float.IsNaN(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10j();
        }
    }
}
