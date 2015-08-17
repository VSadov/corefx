using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // outer is non-empty and inner is non-empty
        public static int Test2()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=43434},
                                                     new CustomerRec{name="Bob", custID=34093}
            };
            OrderRec[] inner = new OrderRec[] { };
            JoinRec[] expected = new JoinRec[] { };
            Func<CustomerRec, OrderRec, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.Join(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
