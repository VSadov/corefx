using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public class Test
    {
        // Overload-2: source has one element
        public static int Test2b()
        {
            CustomerRec[] source = { new CustomerRec { name = "Prakash", total = new int?[] { 90, 55, null, 43, 89 } } };
            int?[] expected = { 90, 55, null, 43, 89 };
            Func<CustomerRec, int, IEnumerable<int?>> selector = (e, index) => e.total;

            var actual = source.SelectMany(selector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2b();
        }
    }
}
