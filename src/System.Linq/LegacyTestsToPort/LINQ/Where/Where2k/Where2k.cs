using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: Test for OverflowException 
        public static int Test2k()
        {
            IEnumerable<int> source = Functions.NumRange(5, (long)Int32.MaxValue+10);
            int[] expected = {}; // Overflow Exception should be thrown
            Func<int, int, bool> predicate = (num, index)=>true;

            try{
                var actual = source.Where(predicate);
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
           // return Test2k();
            return 0;
        }
    }
}
