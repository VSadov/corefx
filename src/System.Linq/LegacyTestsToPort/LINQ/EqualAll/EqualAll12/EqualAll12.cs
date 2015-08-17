using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // Overload-2: Test for EqualityComparer is not-null
        public static int Test12()
        {
            string[] first = { "Bob", "Tim", "Chris" };
            string[] second = { "Bbo", "mTi", "rishC" };
            bool expected = true;

            var actual = first.SequenceEqual(second, new AnagramEqualityComparer());

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test12();
        }
    }
}
