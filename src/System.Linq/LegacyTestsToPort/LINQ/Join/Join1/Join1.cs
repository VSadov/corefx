using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // outer is empty and inner is non-empty
        public static int Test1()
        {
            CustomerRec[] outer = new CustomerRec[] { };
            OrderRec[] inner = new OrderRec[]{  new OrderRec{orderID=45321, custID=98022, total=50},
                                                new OrderRec{orderID=97865, custID=32103, total=25}
            };
            JoinRec[] expected = new JoinRec[] { };
            Func<CustomerRec, OrderRec, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.Join(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
