using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Select
{
    public class Test
    {
        // Overload-1: source is empty
        public static int Test1a()
        {
            CustomerRec[] source = {};
            string[] expected = {};
            Func<CustomerRec, string> selector = (e)=>e.name;

            var actual = source.Select(selector);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test1a();
        }
    }
}
