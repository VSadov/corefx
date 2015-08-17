using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public class Test
    {
        // Overload-2: Test for OverflowException
        public static int Test2g()
        {
            IEnumerable<int> source = Functions.NumRange(5, (long)Int32.MaxValue + 10);
            int[] expected = { }; // OverflowException should be thown
            Func<int, int, IEnumerable<int>> selector = delegate(int e, int index)
            {
                return new int[] { };
            };

            try
            {
                var actual = source.SelectMany(selector);
                Verification.Allequal(source, actual);
                return 1;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            //return Test2g();
            return 0;
        }
    }
}
