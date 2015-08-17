using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        //  source is an long and type is double
        public static int Test9()
        {
            long[] source = { 99L, 45L, 81L};
            double[] expected = { };

            IEnumerable<double> actual = source.OfType<double>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test9();
        }
    }
}
