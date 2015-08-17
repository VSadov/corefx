using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAt
{
    public class Test
    {
        // source is of type IList, source is empty, index is zero
        public static int Test3()
        {
            int[] source = {};
            int index = 0;

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
            return Test3();
        }
    }
}
