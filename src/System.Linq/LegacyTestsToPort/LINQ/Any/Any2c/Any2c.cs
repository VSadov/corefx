using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Any
{
    public class Test
    {
        // Overload with predicate, source has one element and predicate is false
        public static int Test2c()
        {
            int[] source = {5};
            Func<int, bool> predicate = Functions.IsEven;
            bool expected = false;

            var actual = source.Any(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2c();
        }
    }
}
