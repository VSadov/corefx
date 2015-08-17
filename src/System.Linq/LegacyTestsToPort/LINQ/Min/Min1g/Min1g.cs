using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: int, selector function is called
        public static int Test1g()
        {
            Data_int[] source = new Data_int[]{ new Data_int{name="Tim", num=10},
                                                new Data_int{name="John", num=-105},
                                                new Data_int{name="Bob", num=-30}
            };
            int expected = -105;

            var actual = source.Min((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1g();
        }
    }
}
