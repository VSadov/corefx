using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Count
{
    public class Test
    {
        // source has limited number of elements and predicate true for all the elements
        public static int Test5b()
        {
            int[] data = {2, 20, 22, 100, 50, 10};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 6;

            var actual = data.Count(predicate);
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5b();
        }
    }
}
