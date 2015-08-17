using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Last
{
    public class Test
    {
        // source is NOT of type IList, source is empty
        public static int Test1d()
        {
            IEnumerable<int> source = Functions.NumList(0, 0);

            IList<int> list = source as IList<int>;

            if (list != null) return 1;

            try
            {
                var actual = source.Last();
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test1d();
        }
    }
}
