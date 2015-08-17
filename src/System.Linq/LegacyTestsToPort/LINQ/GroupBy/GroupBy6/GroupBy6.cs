using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-4: Duplicate elements are present
        // some of the key elements are null
        public static int Test6()
        {
            // Key anagram of Tim
            string[] key = { null, null, "Chris", "Chris", "Prakash", "Prakash" };
            int[] element = { 55, 25, 49, 24, 9, 9 };
            Record[] source = new Record[]{    new Record{Name = null, Score = 55},
                                                new Record{Name = "Chris", Score = 49},
                                                new Record{Name = "Prakash", Score = 9},                
                                                new Record{Name = "Chris", Score = 24},
                                                new Record{Name = "Prakash", Score = 9},
                                                new Record{Name = null, Score = 25},
            };

            var result = source.GroupBy((e) => e.Name, (e) => e.Score);

            return Verification.MatchAll(key, element, result);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
