using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TakeWhile
{
    public class Test
    {
        // Predicate true for 2nd, 3rd, 4th.... (except 1st)
        // (Predicate with index)
        public static int Test3b()
        {
            int[] source = {3, 2, 4, 12, 6};
            int[] expected = {};
            Func<int, int, bool> predicate = Functions.IsEven_Index;

            var actual = source.TakeWhile(predicate);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3b();
        }
    }
}
