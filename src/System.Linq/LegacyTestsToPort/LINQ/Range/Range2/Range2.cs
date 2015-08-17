using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Range
{
    public class Test
    {
        // start+count-1 is greater than int.MaxValue
        public static int Test2()
        {
            int start = Int32.MaxValue - 10;
            int count = 20; // Throws an Exception
            int[] expected = {}; 

            try {
                var actual = Enumerable.Range(start, count);
                return 1;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                if (aoore.CompareParamName("count"))
                    return 0;
                else
                    return 1;
            }
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
