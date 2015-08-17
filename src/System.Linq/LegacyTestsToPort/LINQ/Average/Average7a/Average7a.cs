using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal, source is empty
        public static int Test7a()
        {
            decimal[] source = { };

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
            return Test7a();
        }
    }
}
