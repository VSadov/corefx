using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LastOrDefault
{
    public class Test
    {
        // source has > one element, predicate is true for 3rd, 6th and 8th element
        public static int Test2e()
        {
            int[] source = {3, 7, 10, 7, 9, 2, 11, 18, 13, 9};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 18;

            var actual = source.LastOrDefault(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2e();
        }
    }
}
