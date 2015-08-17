using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // outerKeySelector matches more than one innerKeySelector
        public static int Test9()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Prakash", custID=98022},
                                                     new CustomerRec{name="Bob", custID=99022},
                                                     new CustomerRec{name="Tim", custID=99021},
                                                     new CustomerRec{name="Robert", custID=99022}
            };
            OrderRec[] inner = new OrderRec[]{  new OrderRec{orderID=45321, custID=18022, total=50},
                                                new OrderRec{orderID=43421, custID=29022, total=20},
                                                new OrderRec{orderID=95421, custID=39021, total=9}
            };
            JoinRec[] expected = new JoinRec[] { };
            Func<CustomerRec, OrderRec, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.Join(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test9();
        }
    }
}
