using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // Overload-2: Test when IEqualityComparer is not-null
        public static int Test10()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=1234},
                                                     new CustomerRec{name="Bob", custID=9865},
                                                     new CustomerRec{name="Robert", custID=9895}
            };
            AnagramRec[] inner = new AnagramRec[]{ new AnagramRec{name = "Robert", orderID=93483, total = 19},
                                                   new AnagramRec{name = "miT", orderID=93489, total = 45}
            };
            JoinRec[] expected = new JoinRec[]{ new JoinRec{name="Tim", orderID=new int?[]{93489}, total=new int?[]{45}},
                                                new JoinRec{name="Bob", orderID=new int?[]{}, total=new int?[]{}},
                                                new JoinRec{name="Robert", orderID=new int?[]{93483}, total=new int?[]{19}}
            };
            Func<CustomerRec, IEnumerable<AnagramRec>, JoinRec> resultSelector = Helper.createJoinRec;

            var actual = outer.GroupJoin(inner, (e) => e.name, (o) => o.name, resultSelector, new AnagramEqualityComparer());

            return Helper.DataEqual(expected, actual);
        }


        public static int Main()
        {
            return Test10();
        }
    }
}
