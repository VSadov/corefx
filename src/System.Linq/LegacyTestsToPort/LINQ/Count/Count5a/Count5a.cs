using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Count
{
    public class Test
    {
        // source does NOT implement ICollection<T> and source has > 1 elements
        public static int Test5a()
        {
            IEnumerable <int> data = Functions.NumRange(5, 10);
            int expected = 10;

            var actual = data.Count();
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5a();
        }
    }
}
