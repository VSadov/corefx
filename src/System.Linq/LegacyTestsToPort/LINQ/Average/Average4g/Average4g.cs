using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: long?, selector function is called
        public static int Test4g()
        {
            Data_Nlong[] source = new Data_Nlong[]{ new Data_Nlong{name="Tim", num=40L},
                                                    new Data_Nlong{name="John", num=null},
                                                    new Data_Nlong{name="Bob", num=30L}
            };
            double? expected = 35;

            var actual = source.Average((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4g();
        }
    }
}
