using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace All
{
    public class Test
    {
        // predicate is true for all elements        
        public static int Test6()
        {
            int[] source = { 4, 2, 10, 12, 8, 6, 14 };
            Func<int, bool> predicate = Functions.IsEven;
            bool expected = true;

            var actual = source.All(predicate);

            return ((expected == actual) ? 0 : 1);
        }

        public static int Main()
        {
            return Test.Test6();
        }
    }
}
