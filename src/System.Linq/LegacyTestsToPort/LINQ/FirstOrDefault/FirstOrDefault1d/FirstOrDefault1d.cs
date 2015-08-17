using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstOrDefault
{
    public class Test
    {
        // source is NOT of type IList, source is empty
        public static int Test1d()
        {
            IEnumerable<int> source = Functions.NumList(0, 0);
            int expected = default(int);

            IList<int> list = source as IList<int>;

            if (list != null) return 1;

            var actual = source.FirstOrDefault();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1d();
        }
    }
}
