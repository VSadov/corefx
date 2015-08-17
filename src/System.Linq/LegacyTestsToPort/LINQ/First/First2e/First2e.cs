using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace First
{
    public class Test
    {
        // source has > one element, predicate is true for 3rd, 6th and last element
        public static int Test2e()
        {
            int[] source = {3, 7, 10, 7, 9, 2, 11, 17, 13, 8};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 10;

            var actual = source.First(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2e();
        }
    }
}
