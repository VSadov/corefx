using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Single
{
    public class Test
    {
        // source has 1 element and predicate is false
        public static int Test2c()
        {
            int[] source = {3};
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
            return Test2c();
        }
    }
}
