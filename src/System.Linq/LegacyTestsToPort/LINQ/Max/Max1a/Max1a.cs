using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: int, source is empty
        public static int Test1a()
        {
            int[] source = { };

            try
            {
                var actual = source.Max();
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
