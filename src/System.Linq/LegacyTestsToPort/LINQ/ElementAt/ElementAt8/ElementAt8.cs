using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAt
{
    public class Test
    {
        // source is NOT of type IList, index = Number of elements in source;
        public static int Test8()
        {
            IEnumerable<int> source = Functions.NumList(5, 5);
            int index = 5;

            IList<int> list = source as IList<int>;

            if (list != null) return 1;

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
            return Test8();
        }
    }
}
