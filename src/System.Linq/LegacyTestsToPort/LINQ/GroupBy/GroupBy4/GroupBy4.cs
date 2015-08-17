using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-3: source has all elements with different keys.
        // Also verifies elementSelector is called
        public static int Test4()
        {
            string[] key = { "Tim", "Chris", "Robert", "Prakash" };
            int[] element = { 60, -10, 40, 100 };
            Record[] source = new Record[]{    new Record{Name = key[0], Score = element[0]},
                                                new Record{Name = key[1], Score = element[1]},
                                                new Record{Name = key[2], Score = element[2]},                
                                                new Record{Name = key[3], Score = element[3]},
            };

            var result = source.GroupBy((e) => e.Name, (e) => e.Score);

            return Verification.MatchAll(key, element, result);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
