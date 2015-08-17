using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

#pragma warning disable 0649
namespace ToLookup
{
    // Class which is passed as an argument for EqualityComparer
    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            if ((x == null) && (y == null))
                return true;

            if ((x == null) || (y == null))
                return false;

            return getCanonicalString(x) == getCanonicalString(y);
        }

        public int GetHashCode(string obj)
        {
            return getCanonicalString(obj).GetHashCode();
        }

        private string getCanonicalString(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort<char>(wordChars);
            return new string(wordChars);
        }
    }

    struct Record
    {

        public string Name;
        public int Score;

    }

    public class Helper
    {
        // The following helper verification function will be used when the PLINQ team runs these tests
        // This is a non-order preserving verification function
#if PLINQ
        public static int MatchAll<K, T>(IEnumerable<K> key, IEnumerable<T> element, System.Linq.ILookup<K, T> lookup)
        {
            int num = 0;

            if ((lookup == null) &&(key == null) &&(element == null)) return 0;

            if ((lookup == null) || (key == null && element == null)) 
            {
                Console.WriteLine("expected key : {0}", key == null ? "null" : key.Count().ToString());
                Console.WriteLine("expected element : {0}", element == null ? "null" : element.Count().ToString());
                Console.WriteLine("actual lookup: {0}", lookup == null ? "null" : lookup.Count().ToString());
                return 1;
            }

            try
            {
                List<T> expectedResults = new List<T>(element);

                using (IEnumerator<K> k1 = key.GetEnumerator())
                using (IEnumerator<T> e1 = element.GetEnumerator())
                {
                    while (k1.MoveNext())
                    {
                        if (!lookup.Contains(k1.Current)) return 1;

                        foreach (T e in lookup[k1.Current])
                        {
                            if (!expectedResults.Contains(e)) return 1;
                            expectedResults.Remove(e);
                        }
                        num = num + 1;
                    }
                }

                if (expectedResults.Count != 0) return 1;
                if (lookup.Count != num) return 1;
                return 0;
            }
            catch(AggregateException ae)
            {
                var innerExceptions = ae.Flatten().InnerExceptions;
                if (innerExceptions.Where(ex => ex != null).Select(ex => ex.GetType()).Distinct().Count() == 1)
                {
                    throw innerExceptions.First();
                }
                else
                {
                    Console.WriteLine(ae);
                }
                return 1;
            }  
        }
#else
        // Helper function to verify that all elements in dictionary are matched (Order Preserving)
        public static int MatchAll<K, T>(IEnumerable<K> key, IEnumerable<T> element, System.Linq.ILookup<K, T> lookup)
        {
            int num = 0;

            if ((lookup == null) && (key == null) && (element == null)) return 0;
            using (IEnumerator<K> k1 = key.GetEnumerator())
            using (IEnumerator<T> e1 = element.GetEnumerator())
            {
                while (k1.MoveNext())
                {
                    if (!lookup.Contains(k1.Current)) return 1;

                    foreach (T e in lookup[k1.Current])
                    {
                        e1.MoveNext();
                        if (!Equals(e, e1.Current)) return 1;
                    }
                    num = num + 1;
                }
            }
            if (lookup.Count != num) return 1;
            return 0;
        }
#endif
    }
}
