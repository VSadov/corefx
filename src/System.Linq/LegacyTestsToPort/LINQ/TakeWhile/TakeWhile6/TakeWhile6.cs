using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TakeWhile
{
    public class Test
    {
        // Test for OverflowException
        public static int Test6()
        {
            IEnumerable<int> source = Functions.NumRange(5, (long)Int32.MaxValue+10);
            int[] expected = {}; // Overflow Exception is thrown

            try{
                var actual = source.TakeWhile((element, index) => true);
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
            //return Test6();
            return 0;
        }
    }
}
