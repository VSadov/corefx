using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: float, selector function is called
        public static int Test9f()
        {
            Data_float[] source = new Data_float[]{ new Data_float{name="Tim", num=9.5f},
                                                new Data_float{name="John", num=10.5f},
                                                new Data_float{name="Bob", num=3.5f}
            };
            float expected = 23.5f;

            var actual = source.Sum((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9f();
        }
    }
}
