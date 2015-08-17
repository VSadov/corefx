using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace First
{
    public class Test
    {
        // source is empty
        public static int Test2a()
        {
            int[] source = {};
            Func<int, bool> predicate = Functions.IsEven;

            try
            {
                var actual = source.First(predicate);
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
