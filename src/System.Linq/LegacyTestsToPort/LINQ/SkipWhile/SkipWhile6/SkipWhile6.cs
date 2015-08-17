using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkipWhile
{
    public class Test
    {
        // Test for OverflowException
        public static int Test6()
        {
            IEnumerable<int> source = Functions.NumRange(5, (long)Int32.MaxValue+10);
            int[] expected = {}; // OverflowException is thrown

            try{
                var actual = source.SkipWhile((element, index) => true);
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
