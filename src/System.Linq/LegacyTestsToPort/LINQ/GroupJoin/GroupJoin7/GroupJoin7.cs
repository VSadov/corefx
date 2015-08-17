using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // outerKeySelector produces same key for more than one element
        // and is matched by one of the innerKeySelector.
        public static int Test7()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=1234},
                                                     new CustomerRec{name="Bob", custID=9865},
                                                      new CustomerRec{name="Robert", custID=9865}
            };
            OrderRec[] inner = new OrderRec[]{ new OrderRec{orderID=97865, custID=1234, total=25},
                                               new OrderRec{orderID=34390, custID=9865, total=19}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Tim", orderID=new int?[]{97865}, total=new int?[]{25}},
                                                new JoinRec{name="Bob", orderID=new int?[]{34390}, total=new int?[]{19}},
                                                new JoinRec{name="Robert", orderID=new int?[]{34390}, total=new int?[]{19}}
            };
            Func<CustomerRec, IEnumerable<OrderRec>, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.GroupJoin(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Helper.DataEqual(expected, actual);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
