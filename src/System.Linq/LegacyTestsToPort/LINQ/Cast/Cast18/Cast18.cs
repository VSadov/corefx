using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        //testing array conversion using .Cast()
        // From Silverlight testing
        public static int Test18()
        {
            try
            {
                var actual = new[] { -4 }.Cast<long>().ToList();
                if (actual[0] == -4)
                    return 1;
                return 1;
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }

        public static int Main()
        {
            return Test18();
        }
    }
}
