using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SingleOrDefault
{
    public class Test
    {
        // source has > 1 element and predicate is false for all
        public static int Test2d()
        {
            int[] source = {3, 1, 7, 9 ,13, 19};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = default(int);

            var actual = source.SingleOrDefault(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2d();
        }
    }
}
