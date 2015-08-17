using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-2: source has all elements with same key.
        // Also verifies comparer function is called.
        public static int Test3()
        {
            // Key anagram of Tim
            string[] key = { "Tim", "Tim", "Tim", "Tim" };
            int[] element = { 60, -10, 40, 100 };
            Record[] source = new Record[]{    new Record{Name = "Tim", Score = element[0]},
                                                new Record{Name = "Tim", Score = element[1]},
                                                new Record{Name = "miT", Score = element[2]},                
                                                new Record{Name = "miT", Score = element[3]},
            };

            var result = source.GroupBy((e) => e.Name, new AnagramEqualityComparer());

            return Verification.MatchAll(key, source, result, new AnagramEqualityComparer());
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
