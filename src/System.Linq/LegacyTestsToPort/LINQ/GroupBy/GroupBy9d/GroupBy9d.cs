using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-7: source has all elements with same key
        // Also verifies comparer function is called.
        public static int Test9d()
        {
            // Key anagram of Tim
            string[] key = { "Tim", "Tim", "Tim", "Tim" };
            int[] element = { 60, -10, 40, 100 };
            Record[] source = new Record[]{    new Record{Name = "Tim", Score = element[0]},
                                                new Record{Name = "Tim", Score = element[1]},
                                                new Record{Name = "miT", Score = element[2]},                
                                                new Record{Name = "miT", Score = element[3]},
            };
            Func<string, IEnumerable<Record>, long> res1 = Helper.resultSelect1;
            long[] expected = { 570 };

            var result = source.GroupBy((e) => e.Name, res1, new AnagramEqualityComparer());

            return Verification.Allequal(expected, result);
        }


        public static int Main()
        {
            return Test9d();
        }
    }
}
