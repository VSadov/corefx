using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: predicate returns true for first element only
        public static int Test2e()
        {
            int[] source = {10, 9, 7, 15, 3, 27};
            int[] expected = {10};
            Func<int, int, bool> predicate = Functions.IsEven_Index;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2e();
        }
    }
}
