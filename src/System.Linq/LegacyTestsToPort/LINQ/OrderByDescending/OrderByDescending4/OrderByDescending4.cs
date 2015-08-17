using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByDescending
{
    public class Test
    {
        // Overload-2: All elements have different keys.
        // Verify keySelector function is called.
        public static int Test4()
        {
            Record[] source = new Record[]{ new Record{Name = "Alpha", Score = 90},
                                            new Record{Name = "Robert", Score = 45},
                                            new Record{Name = "Prakash", Score = 99},
                                            new Record{ Name = "Bob", Score = 0}
            };
            Record[] expected = new Record[]{new Record{Name = "Robert", Score = 45},
                                             new Record{Name = "Prakash", Score = 99},
                                             new Record{Name = "Bob", Score = 0},
                                             new Record{Name = "Alpha", Score = 90}
            };

            var actual = source.OrderByDescending((e) => e.Name, null);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
