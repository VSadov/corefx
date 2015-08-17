using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, source is null
        public static int Test11h()
        {
            float?[] source = { 6.4f, null, null, -0.5f, 9.4f, -0.5f, 10.9f, -0.5f };

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
            return Test11h();
        }
    }
}
