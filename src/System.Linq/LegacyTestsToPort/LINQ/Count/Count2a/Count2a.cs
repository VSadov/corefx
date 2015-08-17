using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Count
{
    public class Test
    {
        // source implements ICollection<T> and source is empty
        public static int Test2a()
        {
            int?[] data = {-10, 4, 9 , null, 11};
            int expected = 5;

            var actual = data.Count();
            return ((expected==actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
