using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAt
{
    public class Test
    {
        // source is NOT of type IList, source has one element, index is zero
        public static int Test10()
        {
            IEnumerable<int> source = Functions.NumList(9, 1);
            int index = 0;
            int expected = 9;

            IList<int> list = source as IList<int>;

            if (list != null) return 1;
            
            var actual = source.ElementAt(index);
            
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10();
        }
    }
}
