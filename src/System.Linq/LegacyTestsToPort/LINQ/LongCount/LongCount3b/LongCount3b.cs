using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LongCount
{
    public class Test
    {
        // source has one element and predicate is false
        public static int Test3b()
        {
            int[] data = {5};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 0;

            var actual = data.LongCount(predicate);
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3b();
        }
    }
}
