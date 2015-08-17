using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    public class Test
    {
        // exception thrown out from first.GetEnumerator
        public static int Test6()
        {
            MyIEnum<int> first = new MyIEnum<int>(new int[] { 1, 3, 3 });
            IEnumerable<int> second = new int[] { 2, 4, 6 };
            Func<int, int, int> func = (x, y) => x + y;
            IEnumerable<int> expected = new int[] { 3, 7, 9 };

            try
            {
                var actual = first.Zip(second, func);
                actual.ToList();        // No exception

                if (Verification.Allequal(expected, actual) != 0)
                    return 1;
            }

            catch (Exception)
            {
                return 1;
            }

            first = new MyIEnum<int>(new int[] { 1, 2, 3 });

            try
            {
                var actual = first.Zip(second, func);
                actual.ToList();        // exception                

                return 1;
            }

            catch (Exception)
            {
                return 0;
            }
        }

        public static int Main()
        {
            return Test6();
        }
    }

    class MyIEnum<T> : IEnumerable<T>
    {
        public T[] datas;

        public MyIEnum(T[] array)
        {
            datas = array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var data in datas)
            {
                if (data.Equals(2))
                    throw new Exception();
                yield return data;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
