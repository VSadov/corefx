using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TakeWhile
{
    public class Test
    {
        // Predicate true for 2nd, 3rd, 4th.... (except 1st)
        // (Predicate without index)
        public static int Test3a()
        {
            int[] source = {3, 2, 4, 12, 6};
            int[] expected = {};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.TakeWhile(predicate);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3a();
        }
    }
}
