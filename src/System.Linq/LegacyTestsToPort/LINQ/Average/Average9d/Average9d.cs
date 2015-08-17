using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: float, source has different values
        public static int Test9d()
        {
            float[] source = { 5.5f, -10f, 15.5f, 40.5f, 28.5f };
            float expected = 16f;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9d();
        }
    }
}
