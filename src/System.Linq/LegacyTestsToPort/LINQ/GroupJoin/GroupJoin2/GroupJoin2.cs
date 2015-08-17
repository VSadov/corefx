using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // outer is non-empty and inner is empty
        public static int Test2()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=43434},
                                                     new CustomerRec{name="Bob", custID=34093}
            };
            OrderRec[] inner = new OrderRec[] { };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Tim", orderID=new int?[]{}, total=new int?[]{}},
                                                new JoinRec{name="Bob", orderID=new int?[]{}, total=new int?[]{}}
            };
            Func<CustomerRec, IEnumerable<OrderRec>, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.GroupJoin(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Helper.DataEqual(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
