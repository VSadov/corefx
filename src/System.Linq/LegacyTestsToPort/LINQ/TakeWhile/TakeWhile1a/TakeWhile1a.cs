using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TakeWhile
{
    public class Test
    {
        // Number of elements in source>0 and predicate returns false for all
        // (Predicate without index)
        public static int Test1a()
        {
            int[] source = {9, 7, 15, 3, 11};
            int[] expected = {};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.TakeWhile(predicate);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
