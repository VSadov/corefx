using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SingleOrDefault
{
    public class Test
    {
        // source is of type IList, source has > 1 element
        public static int Test1c()
        {
            int[] source = {4, 4, 4, 4, 4};

            IList<int> list = source as IList<int>;

            if (list == null) return 1;

            try
            {
                var actual = source.SingleOrDefault();
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test1c();
        }
    }
}
