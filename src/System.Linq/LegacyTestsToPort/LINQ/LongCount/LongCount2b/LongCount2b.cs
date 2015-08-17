using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LongCount
{
    public class Test
    {
        // source has one element and predicate is true
        public static int Test2b()
        {
            int[] data = {4};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 1;

            var actual = data.LongCount(predicate);
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2b();
        }
    }
}
