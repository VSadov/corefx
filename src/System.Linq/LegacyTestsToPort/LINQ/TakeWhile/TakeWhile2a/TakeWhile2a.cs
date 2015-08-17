using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TakeWhile
{
    public class Test
    {
        // Predicate true for 1st, 3rd, 4th.... (except 2nd)
        // (Predicate without index)
        public static int Test2a()
        {
            int[] source = {8, 3, 12, 4, 6, 10};
            int[] expected = {8};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.TakeWhile(predicate);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
