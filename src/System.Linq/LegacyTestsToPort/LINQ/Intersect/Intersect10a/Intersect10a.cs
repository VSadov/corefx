using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // Overload-2: Test when first=null
        public static int Test10a()
        {
            string[] first = { "Tim", "Bob", "Mike", "Robert" };
            string[] second = { "ekiM", "bBo" };

            try
            {
                first = null;
                var actual = first.Intersect(second, new AnagramEqualityComparer());
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                if (!ane.CompareParamName("first")) return 1;
                return 0;
            }
        }


        public static int Main()
        {
            return Test10a();
        }
    }
}
