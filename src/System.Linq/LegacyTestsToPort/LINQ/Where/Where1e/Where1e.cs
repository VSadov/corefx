using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-1: predicate returns true for first element only
        public static int Test1e()
        {
            int[] source = {10, 9, 7, 15, 3, 27};
            int[] expected = {10};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1e();
        }
    }
}
