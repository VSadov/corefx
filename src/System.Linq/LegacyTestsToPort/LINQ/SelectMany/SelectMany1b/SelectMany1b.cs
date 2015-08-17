using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public class Test
    {
        // Overload-1: source has one element
        public static int Test1b()
        {
            CustomerRec[] source = { new CustomerRec { name = "Prakash", total = new int?[] { 90, 55, null, 43, 89 } } };
            int?[] expected = { 90, 55, null, 43, 89 };
            Func<CustomerRec, IEnumerable<int?>> selector = (e) => e.total;

            var actual = source.SelectMany(selector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1b();
        }
    }
}
