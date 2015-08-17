using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, source is empty
        public static int Test10a()
        {
            float[] source = { };

            try
            {
                var actual = source.Min();
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test10a();
        }
    }
}
