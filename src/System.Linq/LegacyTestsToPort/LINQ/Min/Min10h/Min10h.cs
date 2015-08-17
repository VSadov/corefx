using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, source is null
        public static int Test10h()
        {
            float[] source = { -5.5f, float.NegativeInfinity, 9.9f, float.NegativeInfinity };

            try
            {
                source = null;
                var actual = source.Min();
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                if (!ane.CompareParamName("source")) return 1;
                return 0;
            }
        }


        public static int Main()
        {
            return Test10h();
        }
    }
}
