using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Single
{
    public class Test
    {
        // source is NOT of type IList, source has > 1 element
        public static int Test1f()
        {
            IEnumerable<int> source = Functions.NumRange(3, 5);

            IList<int> list = source as IList<int>;

            if (list != null) return 1;

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
            return Test1f();
        }
    }
}
