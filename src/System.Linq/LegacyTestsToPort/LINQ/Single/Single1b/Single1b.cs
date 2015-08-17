using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Single
{
    public class Test
    {
        // source is of type IList, source has only one element
        public static int Test1b()
        {
            int[] source = {4};
            int expected = 4; 

            IList<int> list = source as IList<int>;

            if (list == null) return 1;

            var actual = source.Single();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1b();
        }
    }
}
