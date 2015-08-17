using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float, selector function is called
        public static int Test10g()
        {
            Data_float[] source = new Data_float[]{ new Data_float{name="Tim", num=40.5f},
                                                new Data_float{name="John", num=-10.25f},
                                                new Data_float{name="Bob", num=100.45f}
            };
            float expected = 100.45f;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10g();
        }
    }
}
