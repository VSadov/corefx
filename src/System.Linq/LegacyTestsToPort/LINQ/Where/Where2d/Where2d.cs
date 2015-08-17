using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: predicate returns false for all
        public static int Test2d()
        {
            int[] source = {9, 7, 15, 3, 27};
            int[] expected = {};
            Func<int, int, bool> predicate = Functions.IsEven_Index;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2d();
        }
    }
}
