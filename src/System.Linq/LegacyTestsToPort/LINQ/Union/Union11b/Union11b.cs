using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // Overload-2: second is null
        public static int Test11b()
        {
            string[] first = { "Bob", "Robert", "Tim", "Matt", "miT" };
            string[] second = { "ttaM", "Charlie", "Bbo" };

            try
            {
                second = null;
                var actual = first.Union(second, new AnagramEqualityComparer());
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
            return Test11b();
        }
    }
}
