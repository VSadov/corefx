using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace First
{
    public class Test
    {
        // source is of type IList, source has one element
        public static int Test1b()
        {
            int[] source = {5};
            int expected = 5; 

            IList<int> list = source as IList<int>;

            if (list == null) return 1;

            var actual = source.First();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1b();
        }
    }
}
