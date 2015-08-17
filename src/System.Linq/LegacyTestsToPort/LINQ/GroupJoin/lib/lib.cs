using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

#pragma warning disable 0649
namespace GroupJoin
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

    public struct CustomerRec
    {
        public string name;
        public int? custID;
    }

    public struct OrderRec
    {
        public int? orderID;
        public int? custID;
        public int? total;
    }

    public struct AnagramRec
    {
        public string name;
        public int? orderID;
        public int? total;
    }

    public struct JoinRec
    {
        public string name;
        public int?[] orderID;
        public int?[] total;
    }

    public class Helper
    {
        public static JoinRec createJoinRec(CustomerRec cr, IEnumerable<OrderRec> orIE)
        {
            int count = 0;

            JoinRec jr = new JoinRec();

            jr.name = cr.name;

            jr.orderID = new int?[orIE.Count()];
            jr.total = new int?[orIE.Count()];

            foreach (OrderRec or in orIE)
            {
                jr.orderID[count] = or.orderID;
                jr.total[count] = or.total;
                count++;
            }

            return jr;
        }

        public static JoinRec createJoinRec(CustomerRec cr, IEnumerable<AnagramRec> arIE)
        {
            int count = 0;

            JoinRec jr = new JoinRec();

            jr.name = cr.name;
            jr.orderID = new int?[arIE.Count()];
            jr.total = new int?[arIE.Count()];

            foreach (AnagramRec ar in arIE)
            {
                jr.orderID[count] = ar.orderID;
                jr.total[count] = ar.total;
                count++;
            }

            return jr;
        }

        // The following verification function will be used when the PLINQ team runs these tests
        // This is a non-order preserving verification function
#if PLINQ

        public static int DataEqual(IEnumerable<JoinRec> ele1, IEnumerable<JoinRec> ele2)
        {
            if ((ele1 == null) && (ele2 == null)) return 0;
            if (ele1.Count() != ele2.Count()) return 1;

            List<JoinRec> elt = new List<JoinRec>(ele1);
            foreach (JoinRec e2 in ele2)
            {
                bool contains = false;
                for (int i = 0; i < elt.Count; i++)
                {
                    JoinRec e1 = elt[i];
                    if (e1.name == e2.name && e1.orderID.Count() == e2.orderID.Count()&& e1.total.Count() == e2.total.Count())
                    {
                        bool eq = true;
                        for (int j = 0; j < e1.orderID.Count(); j++)
                        {
                            if (e1.orderID[j] != e2.orderID[j])
                            {
                                eq = false;
                                break;
                            }
                        }

                        for (int j = 0; j < e1.total.Count(); j++)
                        {
                            if (e1.total[j] != e2.total[j])
                            {
                                eq = false;
                                break;
                            }
                        }

                        if (!eq) continue;
                        elt.RemoveAt(i);
                        contains = true;
                        break;
                    }
                }
                if (!contains) return 1;
            }
            return 0;
        }
#else
        // The following is an order preserving verification function
        public static int DataEqual(IEnumerable<JoinRec> ele1, IEnumerable<JoinRec> ele2)
        {
            if ((ele1 == null) && (ele2 == null)) return 0;
            if (ele1.Count() != ele2.Count()) return 1;

            using (IEnumerator<JoinRec> e1 = ele1.GetEnumerator())
            using (IEnumerator<JoinRec> e2 = ele2.GetEnumerator())
            {
                while (e1.MoveNext())
                {
                    e2.MoveNext();
                    JoinRec rec1 = (JoinRec)e1.Current;
                    JoinRec rec2 = (JoinRec)e2.Current;

                    if (rec1.name != rec2.name) return 1;
                    if (rec1.orderID.Count() != rec2.orderID.Count()) return 1;
                    if (rec1.total.Count() != rec2.total.Count()) return 1;

                    int num = rec1.orderID.Count();

                    for (int i = 0; i < num; i++)
                        if (rec1.orderID[i] != rec2.orderID[i]) return 1;

                    num = rec1.total.Count();
                    for (int i = 0; i < num; i++)
                        if (rec1.total[i] != rec2.total[i]) return 1;
                }
            }
            return 0;
        }
#endif
    }
}