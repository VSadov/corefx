using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public class Test
    {
        // Overload-1: source is empty
        public static int Test1a()
        {
            CustomerRec[] source = { };
            int?[] expected = { };
            Func<CustomerRec, IEnumerable<int?>> selector = (e) => e.total;

            var actual = source.SelectMany(selector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
