using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: long?, selector function is called
        public static int Test4g()
        {
            Data_Nlong[] source = new Data_Nlong[]{ new Data_Nlong{name="Tim", num=10L},
                                                new Data_Nlong{name="John", num=Int32.MaxValue},
                                                new Data_Nlong{name="Bob", num=null}
            };
            long expected = (long)Int32.MaxValue + 10;

            var actual = source.Sum((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4g();
        }
    }
}
