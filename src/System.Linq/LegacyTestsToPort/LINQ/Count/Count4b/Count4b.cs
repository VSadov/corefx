using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Count
{
    public class Test
    {
        // source has limited number of elements and predicate true for 1st and last element
        public static int Test4b()
        {
            int[] data = {2, 5, 7, 9, 29, 10};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 2;

            var actual = data.Count(predicate);
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4b();
        }
    }
}
