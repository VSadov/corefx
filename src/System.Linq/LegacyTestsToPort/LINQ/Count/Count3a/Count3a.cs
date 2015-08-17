using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Count
{
    public class Test
    {
        // source does NOT implement ICollection<T> and source is empty
        public static int Test3a()
        {
            IEnumerable <int> data = Functions.NumRange(0, 0);
            int expected = 0;

            var actual = data.Count();
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3a();
        }
    }
}
