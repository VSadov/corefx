using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // outer and inner has only one element and the key matches
        public static int Test3()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=43434}
            };
            OrderRec[] inner = new OrderRec[]{ new OrderRec{orderID=97865, custID=43434, total=25}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Tim", orderID=new int?[]{97865}, total=new int?[]{25}}
            };
            Func<CustomerRec, IEnumerable<OrderRec>, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.GroupJoin(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Helper.DataEqual(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
