using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // Overload-2: Test for first is null
        public static int Test9a()
        {
            string[] first = { "Bob", "Tim", "Robert", "Chris" };
            string[] second = { "bBo", "shriC" };

            try
            {
                first = null;
                var actual = first.Except(second, new AnagramEqualityComparer());
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
            return Test9a();
        }
    }
}
