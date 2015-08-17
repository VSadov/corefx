using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAt
{
    public class Test
    {
        // source is of type IList, index = Number of elements in source;
        public static int Test2()
        {
            int[] source = {1, 2, 3, 4};
            int index = 4;

            IList<int> list = source as IList<int>;

            if (list == null) return 1;

            try
            {
                var actual = source.ElementAt(index);
                return 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
