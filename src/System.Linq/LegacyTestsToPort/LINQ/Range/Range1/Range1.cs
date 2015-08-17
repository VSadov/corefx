using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Range
{
    public class Test
    {
        // count<0
        public static int Test1()
        {
            int start = 5;
            int count = -1; // Throws an Exception
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
            return Test1();
        }
    }
}
