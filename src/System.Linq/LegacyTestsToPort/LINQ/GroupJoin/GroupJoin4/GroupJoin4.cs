using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // outer and inner has only one element and the keys do not match
        public static int Test4()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=43434}
            };
            OrderRec[] inner = new OrderRec[]{ new OrderRec{orderID=97865, custID=49434, total=25}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Tim", orderID=new int?[]{}, total=new int?[]{}}
            };
            Func<CustomerRec, IEnumerable<OrderRec>, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.GroupJoin(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Helper.DataEqual(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
