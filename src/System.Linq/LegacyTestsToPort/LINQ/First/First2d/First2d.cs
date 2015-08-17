using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace First
{
    public class Test
    {
        // source has > one element, predicate is true only for last element
        public static int Test2d()
        {
            int[] source = {9, 5, 1, 3, 17, 21, 50};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 50;

            var actual = source.First(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2d();
        }
    }
}
