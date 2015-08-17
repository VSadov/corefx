using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal, source is empty
        public static int Test7a()
        {
            decimal[] source = { };

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
            return Test7a();
        }
    }
}
