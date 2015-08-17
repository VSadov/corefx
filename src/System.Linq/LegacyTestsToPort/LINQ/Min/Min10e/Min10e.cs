using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, minimum value occurs as the last element
        public static int Test10e()
        {
            float[] source = { 6.8f, 9.4f, 10f, 0,  -5.6f };
            float expected = -5.6f;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10e();
        }
    }
}
