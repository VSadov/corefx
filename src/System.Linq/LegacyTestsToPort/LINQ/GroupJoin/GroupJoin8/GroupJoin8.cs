using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // No match between innerKeySelector and outerKeySelector
        public static int Test8()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=1234},
                                                     new CustomerRec{name="Bob", custID=9865},
                                                     new CustomerRec{name="Robert", custID=9895}
            };
            OrderRec[] inner = new OrderRec[]{ new OrderRec{orderID=97865, custID=2334, total=25},
                                               new OrderRec{orderID=34390, custID=9065, total=19}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Tim", orderID=new int?[]{}, total=new int?[]{}},
                                                new JoinRec{name="Bob", orderID=new int?[]{}, total=new int?[]{}},
                                                new JoinRec{name="Robert", orderID=new int?[]{}, total=new int?[]{}}
            };
            Func<CustomerRec, IEnumerable<OrderRec>, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.GroupJoin(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Helper.DataEqual(expected, actual);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
