using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Count
{
    public class Test
    {
        // source does NOT implement ICollection<T> and source has one element
        public static int Test4a()
        {
            IEnumerable <int> data = Functions.NumRange(5, 1);
            int expected = 1;

            var actual = data.Count();
            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4a();
        }
    }
}
