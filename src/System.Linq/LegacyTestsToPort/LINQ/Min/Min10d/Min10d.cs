using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, minimum value occurs as the first element
        public static int Test10d()
        {
            float[] source = { -2.5f, 4.9f, 130f, 4.7f, 28f };
            float expected = -2.5f;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10d();
        }
    }
}
