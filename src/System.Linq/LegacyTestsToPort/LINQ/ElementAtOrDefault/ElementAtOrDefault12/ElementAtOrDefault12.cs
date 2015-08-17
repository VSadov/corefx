using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAtOrDefault
{
    public class Test
    {
        // source is NOT of type IList, source has > 1 element, index is somewhere in the middle
        public static int Test12()
        {
            IEnumerable<int> source = Functions.NumList(-4, 10);
            int index = 3;
            int expected = -1;

            IList<int> list = source as IList<int>;

            if (list != null) return 1;
            
            var actual = source.ElementAtOrDefault(index);
            
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test12();
        }
    }
}
