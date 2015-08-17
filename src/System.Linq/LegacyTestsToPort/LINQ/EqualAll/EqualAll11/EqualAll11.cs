using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // Overload-2: Test for EqualityComparer is null
        public static int Test11()
        {
            string[] first = { "Bob", "Tim", "Chris"};
            string[] second = { "Bbo", "mTi", "rishC"};
            bool expected = false;

            var actual = first.SequenceEqual(second, null);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11();
        }
    }
}
