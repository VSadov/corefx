// <RelatedBugs>Dev10:407553</RelatedBugs>
using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // func is null
        public static int Test5()
        {
            IEnumerable<int> first = new int[] { 1, 2, 3 };
            IEnumerable<int> second = new int[] { 2, 4, 6 };
            Func<int, int, int> func = null;

            try
            {
                var actual = first.Zip(second, func);
                return 1;
            }

            catch (ArgumentNullException e)
            {
                if (e.ParamName == "resultSelector")
                    return 0;
                else
                    return 1;               
            }
        }

        public static int Main()
        {
            return Test5();
        }
    }
}
