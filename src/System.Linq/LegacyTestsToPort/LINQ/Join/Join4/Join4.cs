using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // outer and inner has only one element and the key do not match
        public static int Test4()
        {
            CustomerRec[] outer = new CustomerRec[] { new CustomerRec { name = "Prakash", custID = 98922 } };
            OrderRec[] inner = new OrderRec[] { new OrderRec { orderID = 45321, custID = 98022, total = 50 } };
            JoinRec[] expected = new JoinRec[] { };
            Func<CustomerRec, OrderRec, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.Join(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
