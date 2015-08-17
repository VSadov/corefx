using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace All
{
    public class Test
    {
        // source is empty        
        public static int Test1()
        {
            int[] source = { };
            Func<int, bool> predicate = Functions.IsEven;
            bool expected = true;

            var actual = source.All(predicate);

            return ((expected == actual) ? 0 : 1);
        }

        public static int Main()
        {
            return Test.Test1();                
        }
    }
}
