using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Select
{
    public class Test
    {
        // Overload-1: source has limited number of elements
        public static int Test1c()
        {
            CustomerRec[] source = {new CustomerRec{name="Prakash", custID=98088},
                                    new CustomerRec{name="Bob", custID=29099},
                                    new CustomerRec{name="Chris", custID=39033},
                                    new CustomerRec{name=null, custID=30349},
                                    new CustomerRec{name="Prakash", custID=39030}
            };
            string[] expected = {"Prakash", "Bob", "Chris", null, "Prakash"};
            Func<CustomerRec, string> selector = (e)=>e.name;

            var actual = source.Select(selector);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test1c();
        }
    }
}
