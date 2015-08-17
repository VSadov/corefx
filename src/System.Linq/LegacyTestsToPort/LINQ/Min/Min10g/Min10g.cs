using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, selector function is called
        public static int Test10g()
        {
            Data_float[] source = new Data_float[]{ new Data_float{name="Tim", num=-45.5f},
                                                new Data_float{name="John", num=-132.5f},
                                                new Data_float{name="Bob", num=20.45f}
            };
            float expected = -132.5f;

            var actual = source.Min((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10g();
        }
    }
}
