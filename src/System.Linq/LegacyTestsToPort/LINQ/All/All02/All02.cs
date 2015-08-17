using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace All
{
    public class Test
    {
        // source has one element and predicate is false        
        public static int Test2()
        {
            int[] source = { 3 };
            Func<int, bool> predicate = Functions.IsEven;
            bool expected = false;

            var actual = source.All(predicate);

            return ((expected == actual) ? 0 : 1);
        }

        public static int Main()
        {
            return Test.Test2();
        }
    }
}
