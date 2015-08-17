using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: bool, source is empty,  default(T) is NOT null
        public static int Test9a()
        {
            bool[] source = { };

            try
            {
                var actual = source.Min();
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test9a();
        }
    }
}
