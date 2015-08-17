using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDictionary
{
    public class Test
    {
        // Overload-4
        public static void Test4_1()
        {
            Record[] source =  new Record[3];

            source[0].Name = "Chris";   source[0].Score = 50;
            source[1].Name = "Bob";     source[1].Score = 95;
            source[2].Name = "null";    source[2].Score = 55;

            var result = source.ToDictionary((e)=>e.Name, (e)=>e, new AnagramEqualityComparer());
        }

        // Overload-4: keySelector returns null
        public static int Test4_2()
        {
            Record[] source =  new Record[3];

            source[0].Name = "Chris";   source[0].Score = 50;
            source[1].Name = "Bob";     source[1].Score = 95;
            source[2].Name = null;      source[2].Score = 55;

            try
            {
                var result = source.ToDictionary((e)=>e.Name, (e)=>e, new AnagramEqualityComparer());
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                return 0;
            }
        }

        public static int Main()
        {
            Test4_1();
            return Test4_2();
        }
    }
}
