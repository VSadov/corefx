using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LastOrDefault
{
    public class Test
    {
        // source has > one element, predicate is false for all
        public static int Test2c()
        {
            int[] source = {9, 5, 1, 3, 17, 21};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = default(int);

            var actual = source.LastOrDefault(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2c();
        }
    }
}
