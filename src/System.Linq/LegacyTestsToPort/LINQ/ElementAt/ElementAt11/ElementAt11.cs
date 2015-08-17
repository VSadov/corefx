using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAt
{
    public class Test
    {
        // source is NOT of type IList, source has > 1 element, index is (# of elements - 1)
        public static int Test11()
        {
            IEnumerable<int> source = Functions.NumList(9, 10);
            int index = 9;
            int expected = 18;

            IList<int> list = source as IList<int>;

            if (list != null) return 1;
            
            var actual = source.ElementAt(index);
            
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11();
        }
    }
}
