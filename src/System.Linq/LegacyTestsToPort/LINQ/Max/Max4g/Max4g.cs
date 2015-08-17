using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long?, selector function is called
        public static int Test4g()
        {
            Data_Nlong[] source = new Data_Nlong[]{ new Data_Nlong{name="Tim", num=null},
                                                new Data_Nlong{name="John", num=-105L},
                                                new Data_Nlong{name="Bob", num=Int64.MaxValue}
            };
            long? expected = Int64.MaxValue;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4g();
        }
    }
}
