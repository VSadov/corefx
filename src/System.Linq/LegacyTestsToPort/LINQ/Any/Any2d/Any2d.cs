using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Any
{
    public class Test
    {
        // Overload with predicate, predicate is true only for last element
        public static int Test2d()
        {
            int[] source = {5, 9, 3, 7, 4};
            Func<int, bool> predicate = Functions.IsEven;
            bool expected = true;

            var actual = source.Any(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2d();
        }
    }
}
