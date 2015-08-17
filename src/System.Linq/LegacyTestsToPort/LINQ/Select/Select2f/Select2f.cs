using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Select
{
    public class Test
    {
        // Overload-2: Check for overflow exception
        public static int Test2f()
        {
            IEnumerable<int> source = Functions.NumRange(5, (long)Int32.MaxValue+10);
            int[] expected = {}; // Overflow Exception is thrown
            Func<int, int, int> selector = (e, index)=>e;

            try{
                var actual = source.Select(selector);
                Verification.Allequal(source, actual);
                return 1;
            }
            catch (OverflowException)
            {
                return 0;
            }
         }


        public static int Main()
        {
            //return Test2f();
            return 0;
        }
    }
}
