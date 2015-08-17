using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: decimal?, Negative Overflow exception is thrown
        public static int Test8f()
        {
            decimal?[] source = { -Decimal.MaxValue, -Decimal.MaxValue };

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
            return Test8f();
        }
    }
}
