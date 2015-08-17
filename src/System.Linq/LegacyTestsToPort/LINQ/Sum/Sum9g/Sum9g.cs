using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: float, source is null
        public static int Test9g()
        {
            float[] source = { -float.MaxValue, -float.MaxValue };

            try
            {
                source = null;
                float actual = source.Sum();
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
            return Test9g();
        }
    }
}
