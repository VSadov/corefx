using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Last
{
    public class Test
    {
        // source has > one element, predicate is false for all
        public static int Test2c()
        {
            int[] source = {9, 5, 1, 3, 17, 21};
            Func<int, bool> predicate = Functions.IsEven;

            try
            {
                var actual = source.Last(predicate);
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
