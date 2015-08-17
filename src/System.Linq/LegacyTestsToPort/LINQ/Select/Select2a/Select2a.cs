using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Select
{
    public class Test
    {
        // Overload-2: source is empty
        public static int Test2a()
        {
            CustomerRec[] source = {};
            string[] expected = {};
            Func<CustomerRec, int, string> selector = (e,index)=>e.name;

            var actual = source.Select(selector);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test2a();
        }
    }
}
