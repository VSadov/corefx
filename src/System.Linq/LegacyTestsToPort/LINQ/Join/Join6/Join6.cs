using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // innerKeySelector produces same key for more than one element and is
        // matched by one of the outerKeySelector.
        // Also tests the scenario where outerKeySelector matches more than one
        // of the innerKeySelector.
        // Also tests the scenario where inner has more elements than outer.
        public static int Test6()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Prakash", custID=98022},
                                                     new CustomerRec{name="Tim", custID=99021},
                                                     new CustomerRec{name="Robert", custID=99022} 
            };
            OrderRec[] inner = new OrderRec[]{  new OrderRec{orderID=45321, custID=98022, total=50},
                                                new OrderRec{orderID=45421, custID=98022, total=10},
                                                new OrderRec{orderID=43421, custID=99022, total=20},
                                                new OrderRec{orderID=85421, custID=98022, total=18},
                                                new OrderRec{orderID=95421, custID=99021, total=9}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Prakash", orderID=45321, total=50},
                                                new JoinRec{name="Prakash", orderID=45421, total=10},
                                                new JoinRec{name="Prakash", orderID=85421, total=18},
                                                new JoinRec{name="Tim", orderID=95421, total=9},
                                                new JoinRec{name="Robert", orderID=43421, total=20}
            };
            Func<CustomerRec, OrderRec, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.Join(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
