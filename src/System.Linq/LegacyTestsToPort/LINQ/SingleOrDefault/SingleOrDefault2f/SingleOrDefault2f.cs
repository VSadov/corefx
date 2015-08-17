using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SingleOrDefault
{
    public class Test
    {
        // source has > 1 element and predicate is true for 1st and 5th element
        public static int Test2f()
        {
            int[] source = {2, 3, 1, 7, 10 ,13, 19, 9};
            Func<int, bool> predicate = Functions.IsEven;

            try
            {
                var actual = source.SingleOrDefault(predicate);
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test2f();
        }
    }
}
