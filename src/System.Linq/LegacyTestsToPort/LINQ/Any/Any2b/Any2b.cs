using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Any
{
    public class Test
    {
        // Overload with predicate, source has one element and predicate is true
        public static int Test2b()
        {
            int[] source = {4};
            Func<int, bool> predicate = Functions.IsEven;
            bool expected = true;

            var actual = source.Any(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2b();
        }
    }
}
