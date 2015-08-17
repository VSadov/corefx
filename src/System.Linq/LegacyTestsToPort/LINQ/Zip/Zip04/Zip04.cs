using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // second is null
        public static int Test4()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3 };
            IEnumerable<int> second = null;

            try
            {
                var actual = first.Zip<int, int, int>(second, (x, y) => x + y);
                return 1;
            }

            catch (ArgumentNullException e)
            {
                if (e.ParamName == "second")
                    return 0;
                else
                    return 1;
            }
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
