using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // innerKeySelector, outerKeySelector returns null
        // Also tests outerKeySelector matches more than one innerKeySelector
        public static int Test5()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=null},
                                                     new CustomerRec{name="Bob", custID=null}
            };
            OrderRec[] inner = new OrderRec[]{ new OrderRec{orderID=97865, custID=null, total=25},
                                               new OrderRec{orderID=34390, custID=null, total=19}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Tim", orderID=new int?[]{}, total=new int?[]{}},
                                                new JoinRec{name="Bob", orderID=new int?[]{}, total=new int?[]{}}
            };
            Func<CustomerRec, IEnumerable<OrderRec>, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.GroupJoin(inner, (e) => e.custID, (o) => o.custID, resultSelector);

            return Helper.DataEqual(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
