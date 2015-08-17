using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Select
{
    public class Test
    {
        // Overload-2: index=max value is right
        public static int Test2e()
        {
            CustomerRec[] source = {new CustomerRec{name="Prakash", custID=98088},
                                    new CustomerRec{name="Bob", custID=29099},
                                    new CustomerRec{name="Chris", custID=39033},
                                    new CustomerRec{name="Robert", custID=39033},
                                    new CustomerRec{name="Allen", custID=39033},
                                    new CustomerRec{name="Chuck", custID=39033}
            };
            string[] expected = {null, null, null, null, null, "Chuck"};
            Func<CustomerRec, int, string> selector = Helper.index_five;

            var actual = source.Select(selector);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test2e();
        }
    }
}
