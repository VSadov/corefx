using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: int?, negative OverflowException is caused 
        public static int Test2f()
        {
            int?[] source = { -Int32.MaxValue, 0, -5, null, null, -20 };

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
            return Test2f();
        }
    }
}
