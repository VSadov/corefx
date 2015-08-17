using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double, source is empty
        public static int Test5a()
        {
            double[] source = { };

            try
            {
                var actual = source.Average();
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test5a();
        }
    }
}
