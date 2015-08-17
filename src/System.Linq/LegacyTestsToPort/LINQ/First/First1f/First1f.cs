using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace First
{
    public class Test
    {
        // source is NOT of type IList, source has > 1 element
        public static int Test1f()
        {
            IEnumerable<int> source = Functions.NumList(3, 10);
            int expected = 3; 

            IList<int> list = source as IList<int>;

            if (list != null) return 1;

            var actual = source.First();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1f();
        }
    }
}
