using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public class Test
    {
        // Overload-1: source is non-empty but IEnumerable returned by selector is empty
        public static int Test1c()
        {
            CustomerRec[] source = {new CustomerRec{name="Prakash", total=new int?[]{}},
                                    new CustomerRec{name="Bob", total=new int?[]{}},
                                    new CustomerRec{name="Chris", total=new int?[]{}},
                                    new CustomerRec{name=null, total=new int?[]{}},
                                    new CustomerRec{name="Prakash", total=new int?[]{}}
            };
            int?[] expected = { };
            Func<CustomerRec, IEnumerable<int?>> selector = (e) => e.total;

            var actual = source.SelectMany(selector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1c();
        }
    }
}
