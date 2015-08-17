using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Single
{
    public class Test
    {
        // source is of type IList, source is empty
        public static int Test1a()
        {
            int[] source = {};

            IList<int> list = source as IList<int>;

            if (list == null) return 1;

            try
            {
                var actual = source.Single();
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
