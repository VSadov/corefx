using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-1: predicate returns false for all
        public static int Test1d()
        {
            int[] source = {9, 7, 15, 3, 27};
            int[] expected = {};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1d();
        }
    }
}
