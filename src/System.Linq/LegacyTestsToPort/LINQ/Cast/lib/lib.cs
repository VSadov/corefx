using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

#pragma warning disable 0649
namespace Cast
{
    public class Helper
    {
        // Helper Method for Test15 and Test16
        public static int GenericTest<T>(object o, T[] expected)
        {
            byte? i = 10;
            Object[] source = { -1, 0, o, i };

            IEnumerable<int?> source1 = source.Cast<int?>();
            IEnumerable<T> actual = source1.Cast<T>();

            return Verification.Allequal(expected, actual);
        }
    }
}
