using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Single
{
    public class Test
    {
        // source has > 1 element and predicate is true only for last element
        public static int Test2e()
        {
            int[] source = {3, 1, 7, 9 ,13, 19, 20};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 20;

            var actual = source.Single(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2e();
        }
    }
}
