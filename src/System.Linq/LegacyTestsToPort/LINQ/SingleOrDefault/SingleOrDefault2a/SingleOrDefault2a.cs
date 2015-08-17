using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SingleOrDefault
{
    public class Test
    {
        // source is empty
        public static int Test2a()
        {
            int[] source = {};
            Func<int, bool> predicate = Functions.IsEven;
            int expected = default(int);

            var actual = source.SingleOrDefault(predicate);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
