using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

#pragma warning disable 0649
namespace Contains
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

    public class Helper
    {
        // Helper function for Test2f
        public static IEnumerable<int?> NumList_Non_Null(int? start, int? count)
        {
            for (int? i = 0; i < count; i++)
                yield return start + i;
        }

        // Helper function for Test 2g
        public static IEnumerable<int?> NumList_Null(int count)
        {
            for (int i = 0; i < count; i++)
                yield return null;
        }
    }
}