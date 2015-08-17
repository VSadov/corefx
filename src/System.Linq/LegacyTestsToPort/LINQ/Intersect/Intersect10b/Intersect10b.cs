using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // Overload-2: Test when second=null
        public static int Test10b()
        {
            string[] first = { "Tim", "Bob", "Mike", "Robert" };
            string[] second = { "ekiM", "bBo" };

            try
            {
                second = null;
                var actual = first.Intersect(second, new AnagramEqualityComparer());
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                if (!ane.CompareParamName("second")) return 1;
                return 0;
            }
        }


        public static int Main()
        {
            return Test10b();
        }
    }
}
