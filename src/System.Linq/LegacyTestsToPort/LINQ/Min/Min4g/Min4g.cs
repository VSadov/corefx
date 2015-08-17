using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: long?, selector function is called
        public static int Test4g()
        {
            Data_Nlong[] source = new Data_Nlong[]{ new Data_Nlong{name="Tim", num=null},
                                                new Data_Nlong{name="John", num=Int64.MinValue},
                                                new Data_Nlong{name="Bob", num=-10L}
            };
            long? expected = Int64.MinValue;

            var actual = source.Min((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4g();
        }
    }
}
