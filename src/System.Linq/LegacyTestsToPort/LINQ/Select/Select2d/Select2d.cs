using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Select
{
    public class Test
    {
        // Overload-2: index=0 returns the first element from source
        public static int Test2d()
        {
            CustomerRec[] source = {new CustomerRec{name="Prakash", custID=98088},
                                    new CustomerRec{name="Bob", custID=29099},
                                    new CustomerRec{name="Chris", custID=39033},
            };
            string[] expected = {"Prakash", null, null};
            Func<CustomerRec, int, string> selector = Helper.index_zero;

            var actual = source.Select(selector);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test2d();
        }
    }
}
