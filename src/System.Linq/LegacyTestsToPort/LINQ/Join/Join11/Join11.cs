using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // Overload-2: Test when IEqualityComparer is null
        public static int Test11()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Prakash", custID=98022},
                                                     new CustomerRec{name="Tim", custID=99021},
                                                     new CustomerRec{name="Robert", custID=99022}
            };
            AnagramRec[] inner = new AnagramRec[]{  new AnagramRec{name = "miT", orderID = 43455, total = 10},
                                                    new AnagramRec{name = "Prakash", orderID = 323232, total = 9}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Prakash", orderID=323232, total=9},
            };
            Func<CustomerRec, AnagramRec, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.Join(inner, (e) => e.name, (o) => o.name, resultSelector, null);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test11();
        }
    }
}
