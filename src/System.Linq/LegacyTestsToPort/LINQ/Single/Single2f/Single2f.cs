using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Single
{
    public class Test
    {
        // source has > 1 element and predicate is true for 1st and last element
        public static int Test2f()
        {
            int[] source = {2, 3, 1, 7, 9 ,13, 19, 10};
            Func<int, bool> predicate = Functions.IsEven;

            try
            {
                var actual = source.Single(predicate);
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
