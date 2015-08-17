using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Last
{
    public class Test
    {
        // source has one element, predicate is true
        public static int Test2b()
        {
            int[] source = {4};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 4; 

            var actual = source.Last(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2b();
        }
    }
}
