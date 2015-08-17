using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal?, OverflowException is thrown by param sum
        public static int Test8h()
        {
            decimal?[] source = { decimal.MaxValue, decimal.MaxValue };

            try
            {
                var actual = source.Average();
                return 1;
            }
            catch (OverflowException)
            {
                return 0;
            }

        }


        public static int Main()
        {
            return Test8h();
        }
    }
}
