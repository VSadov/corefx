using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkipWhile
{
    public class Test
    {
        // Predicate true for 1st, 3rd, 4th.... (except 2nd)
        // (Predicate with index)
        public static int Test2b()
        {
            int[] source = {8, 3, 12, 4, 6, 10};
            int[] expected = {3, 12, 4, 6, 10};
            Func<int, int, bool> predicate = Functions.IsEven_Index;

            var actual = source.SkipWhile(predicate);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2b();
        }
    }
}
