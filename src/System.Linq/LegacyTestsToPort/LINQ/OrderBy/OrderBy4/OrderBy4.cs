using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderBy
{
    public class Test
    {
        // Overload-2: All elements have different keys.
        // Verify keySelector function is called.
        public static int Test4()
        {
            Record[] source = new Record[]{ new Record{Name = "Tim", Score = 90},
                                            new Record{Name = "Robert", Score = 45},
                                            new Record{Name = "Prakash", Score = 99}
            };
            Record[] expected = new Record[]{new Record{Name = "Prakash", Score = 99},
                                             new Record{Name = "Robert", Score = 45},
                                             new Record{Name = "Tim", Score = 90}
            };

            var actual = source.OrderBy((e) => e.Name, null);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
