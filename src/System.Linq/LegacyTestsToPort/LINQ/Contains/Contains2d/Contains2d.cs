using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // value is last element in source
        public static int Test2d()
        {
            IEnumerable<int> source = Functions.NumList(3, 5);
            int value = 7;
            bool expected = true;

            // Check whether source is actually ICollection
            ICollection<int> collection = source as ICollection<int>;
            if (collection != null) return 1;

            var actual = source.Contains(value);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2d();
        }
    }
}
