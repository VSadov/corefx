using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // Overload-2: first is null
        public static int Test11a()
        {
            string[] first = { "Bob", "Robert", "Tim", "Matt", "miT" };
            string[] second = { "ttaM", "Charlie", "Bbo" };

            try
            {
                first = null;
                var actual = first.Union(second, new AnagramEqualityComparer());
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
            return Test11a();
        }
    }
}
