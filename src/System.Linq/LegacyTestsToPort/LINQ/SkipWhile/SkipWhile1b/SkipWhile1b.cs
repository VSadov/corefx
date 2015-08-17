using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkipWhile
{
    public class Test
    {
        // Number of elements in source>0 and predicate returns true for all
        // (Predicate with index)
        public static int Test1b()
        {
            int[] source = {6, 8, 10, 12, 4};
            int[] expected = {};
            Func<int, int, bool> predicate = Functions.IsEven_Index;

            var actual = source.SkipWhile(predicate);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1b();
        }
    }
}
