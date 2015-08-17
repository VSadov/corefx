using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Last
{
    public class Test
    {
        // source is NOT of type IList, source has one element
        public static int Test1e()
        {
            IEnumerable<int> source = Functions.NumList(-5, 1);
            int expected = -5; 

            IList<int> list = source as IList<int>;

            if (list != null) return 1;

            var actual = source.Last();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1e();
        }
    }
}
