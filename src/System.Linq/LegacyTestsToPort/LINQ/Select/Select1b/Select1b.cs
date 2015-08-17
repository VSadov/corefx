using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Select
{
    public class Test
    {
        // Overload-1: source has one element
        public static int Test1b()
        {
            CustomerRec[] source = {new CustomerRec{name="Prakash", custID=98088}};
            string[] expected = {"Prakash"};
            Func<CustomerRec, string> selector = (e)=>e.name;

            var actual = source.Select(selector);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test1b();
        }
    }
}
