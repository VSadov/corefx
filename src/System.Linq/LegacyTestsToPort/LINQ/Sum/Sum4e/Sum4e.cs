using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: long?, OverflowException is caused 
        public static int Test4e()
        {
            long?[] source = { Int64.MaxValue, 0, -5, 20, null, null };

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
            return Test4e();
        }
    }
}
