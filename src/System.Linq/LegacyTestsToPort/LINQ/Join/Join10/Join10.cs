using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // key for first element in outer matches with key for last element in inner
        // key for last element in outer matches with key for first element in inner
        // Also tests the scnario where inner and outer has the same number of elements
        public static int Test10()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Prakash", custID=98022},
                                                     new CustomerRec{name="Tim", custID=99021},
                                                     new CustomerRec{name="Robert", custID=99022}
            };
            OrderRec[] inner = new OrderRec[]{  new OrderRec{orderID=45321, custID=99022, total=50},
                                                new OrderRec{orderID=43421, custID=29022, total=20},
                                                new OrderRec{orderID=95421, custID=98022, total=9}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Prakash", orderID=95421, total=9},
                                                new JoinRec{name="Robert", orderID=45321, total=50}
            };
            Func<CustomerRec, OrderRec, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.Join(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test10();
        }
    }
}
