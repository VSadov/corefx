using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

#pragma warning disable 0649
namespace GroupBy
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

    public struct Record
    {
        public string Name;
        public int Score;
    }

    public class Helper
    {
        // Helper function-1 to act as resultSelector
        public static long resultSelect1(string key, IEnumerable<Record> elements)
        {
            long result = 0;
            foreach (Record element in elements)
            {
                result = result + element.Score;
            }

            if (key != null)
                result = result * key.Length;

            return result;
        }

        // Helper function-2 to act as resultSelector
        public static long resultSelect2(string key, IEnumerable<int> elements)
        {
            long result = 0;

            foreach (int element in elements)
            {
                result = result + element;
            }

            if (key != null)
                result = result * key.Length;

            return result;
        }
    }
}