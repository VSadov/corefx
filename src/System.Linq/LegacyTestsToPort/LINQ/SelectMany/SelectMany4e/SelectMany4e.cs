using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public class Test
    {
        // Overload-4: Test to verify that index = zero matches 1st element
        public static int Test4e()
        {
            CustomerRec[] source = {new CustomerRec{name="Prakash", total=new int?[]{1, 2, 3, 4}},
                                    new CustomerRec{name="Bob", total=new int?[]{5, 6}},
                                    new CustomerRec{name="Chris", total=new int?[]{}},
                                    new CustomerRec{name=null, total=new int?[]{8, 9}},
                                    new CustomerRec{name="Prakash", total=new int?[]{-10, 100}}
            };

            string[] expected = { "1", "2", "3", "4"};
            Func<CustomerRec, int, IEnumerable<int?>> selector = Helper.index_zero;
            Func<CustomerRec, int?, string> resultSelector = (e, f) => f.ToString();

            var actual = source.SelectMany(selector, resultSelector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4e();
        }
    }
}
