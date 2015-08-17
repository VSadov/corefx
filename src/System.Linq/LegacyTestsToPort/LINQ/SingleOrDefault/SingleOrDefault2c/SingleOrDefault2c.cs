using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SingleOrDefault
{
    public class Test
    {
        // source has 1 element and predicate is false
        public static int Test2c()
        {
            int[] source = {3};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = default(int);

            var actual = source.SingleOrDefault(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2c();
        }
    }
}
