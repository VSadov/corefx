using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAt
{
    public class Test
    {
        // source is of type IList, source has > 1 element, index is (# of elements - 1)
        public static int Test5()
        {
            int[] source = {9, 8, 0, -5, 10};
            int index = 4;
            int expected = 10;

            IList<int> list = source as IList<int>;

            if (list == null) return 1;
            
            var actual = source.ElementAt(index);
            
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
