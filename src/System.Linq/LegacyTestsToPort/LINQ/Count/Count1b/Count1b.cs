using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Count
{
    public class Test
    {
        // source is empty
        public static int Test1b()
        {
            int[] data = {};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = 0;

            var actual = data.Count(predicate);
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1b();
        }
    }
}
