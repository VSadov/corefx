using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace All
{
    public class Test
    {
        // predicate is true for all except 3rd and 4th elements        
        public static int Test4()
        {
            int[] source = { 4, 8, 3, 5, 10, 20, 12 };
            Func<int, bool> predicate = Functions.IsEven;
            bool expected = false;

            var actual = source.All(predicate);

            return ((expected == actual) ? 0 : 1);
        }

        public static int Main()
        {
            return Test.Test4();
        }
    }
}
