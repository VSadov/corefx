using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDictionary
{
    // Class which is passed as an argument for EqualityComparer
    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
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
#pragma warning disable 0649
        public string Name;
        public int Score;
#pragma warning restore 0649
    }

    public class Helper
    {
        // Helper function to verify that all elements in dictionary are matched
        public static int MatchAll<K, E>(IEnumerable<K> key, IEnumerable<E> element, Dictionary<K, E> dict)
        {
            if ((dict == null) && (key == null) && (element == null)) return 0;
            using (IEnumerator<K> k1 = key.GetEnumerator())
            using (IEnumerator<E> e1 = element.GetEnumerator())
            {
                while (k1.MoveNext() && e1.MoveNext())
                {
                    if (!dict.ContainsKey(k1.Current)) return 1;
                    if (!Equals(dict[k1.Current], e1.Current)) return 1;
                    if (!dict.Remove(k1.Current)) return 1;
                }
            }
            if (dict.Count != 0) return 1;
            return 0;
        }
    }
}
