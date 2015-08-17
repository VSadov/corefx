using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // value is 1st element in source
        public static int Test1c()
        {
            int[] source = { 8, 10, 3, 0, -8 };
            int value = 8;
            bool expected = true;

            // Check whether source is actually ICollection
            ICollection<int> collection = source as ICollection<int>;
            if (collection == null) return 1;

            var actual = source.Contains(value);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1c();
        }
    }
}
