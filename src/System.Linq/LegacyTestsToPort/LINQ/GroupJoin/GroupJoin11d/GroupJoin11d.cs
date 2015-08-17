using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // Overload-2: Test when innerKeySelector is null
        public static int Test11d()
        {
            CustomerRec[] outer = new CustomerRec[]{ new CustomerRec{name="Tim", custID=1234},
                                                     new CustomerRec{name="Bob", custID=9865},
                                                     new CustomerRec{name="Robert", custID=9895}
            };
            AnagramRec[] inner = new AnagramRec[]{ new AnagramRec{name = "Robert", orderID=93483, total = 19},
                                                   new AnagramRec{name = "miT", orderID=93489, total = 45}
            };
            Func<CustomerRec, IEnumerable<AnagramRec>, JoinRec> resultSelector = Helper.createJoinRec;

            try
            {
                var actual = outer.GroupJoin(inner, (e) => e.name, null, resultSelector, new AnagramEqualityComparer());
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                if (!ane.CompareParamName("innerKeySelector")) return 1;
                return 0;
            }
        }


        public static int Main()
        {
            return Test11d();
        }
    }
}
