using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // first is null
        public static int Test3()
        {
            IEnumerable<int> first = null;
            IEnumerable<int> second = new int[] { 2, 5, 9 };

            try
            {
                var actual = first.Zip<int, int, int>(second, (x, y) => x + y);
                return 1;
            }

            catch (ArgumentNullException e)
            {
                if (e.ParamName == "first")
                    return 0;
                else
                    return 1;               
            }
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
