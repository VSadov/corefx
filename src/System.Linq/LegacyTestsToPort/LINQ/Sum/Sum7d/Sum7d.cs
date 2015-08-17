using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: decimal, Positive Overflow exception is thrown
        public static int Test7d()
        {
            decimal[] source = { Decimal.MaxValue, Decimal.MaxValue, 0, 0 };

            try
            {
                var actual = source.Sum();
                return 1;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test7d();
        }
    }
}
