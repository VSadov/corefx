using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: int, selector function is called
        public static int Test1g()
        {
            Data_int[] source = new Data_int[]{ new Data_int{name="Tim", num=10},
                                                new Data_int{name="John", num=-105},
                                                new Data_int{name="Bob", num=30}
            };
            int expected = 30;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1g();
        }
    }
}
