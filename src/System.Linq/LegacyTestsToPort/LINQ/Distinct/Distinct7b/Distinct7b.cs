using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // Overload-2: Test when source is null
        public static int Test7b()
        {
            string[] source = { "Bob", "Tim", "bBo", "miT", "Robert", "iTm" };
            string[] expected = { "Bob", "Tim", "bBo", "miT", "Robert", "iTm" };

            try
            {
                source = null;
                var actual = source.Distinct(new AnagramEqualityComparer());
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                if (!ane.CompareParamName("source")) return 1;
                return 0;
            }
        }


        public static int Main()
        {
            return Test7b();
        }
    }
}
