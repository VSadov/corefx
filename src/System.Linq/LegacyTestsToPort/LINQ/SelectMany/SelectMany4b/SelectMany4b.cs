using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public class Test
    {
        // Overload-4: Verify if resultSelector is null an exception is thrown
        public static int Test4b()
        {
            CustomerRec[] source = {new CustomerRec{name="Prakash", total=new int?[]{1, 2, 3, 4}},
                                    new CustomerRec{name="Bob", total=new int?[]{5, 6}},
                                    new CustomerRec{name="Chris", total=new int?[]{}},
                                    new CustomerRec{name=null, total=new int?[]{8, 9}},
                                    new CustomerRec{name="Prakash", total=new int?[]{-10, 100}}
            };

            string[] expected = { "1", "2", "3", "4", "5", "6", "8", "9", "-10", "100" };
            Func<CustomerRec, int, IEnumerable<int?>> selector = (e, f) => e.total;
            Func<CustomerRec, int?, string> resultSelector = (e, f) => f.ToString();
            resultSelector = null;

            try
            {
                var actual = source.SelectMany(selector, resultSelector);
                return 1;
            }
            catch (ArgumentException ae)
            {
                if (ae.CompareParamName("resultSelector")) return 0;
                return 1;
            }
        }


        public static int Main()
        {
            return Test4b();
        }
    }
}
