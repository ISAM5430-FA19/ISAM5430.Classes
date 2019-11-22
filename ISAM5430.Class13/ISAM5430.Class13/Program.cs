using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
           
            int j = 1;

            Console.WriteLine("Enter the number of trailing digits:");
            string mstring = Console.ReadLine();
            int m;
            if (string.IsNullOrEmpty(mstring) || !int.TryParse(mstring, out m))
            {
                Console.Error.WriteLine("The number of trailing digits is invalid");
                return;
            }
            IEnumerable<long> list;
            try
            {
                // list = Calc2(m);
                //list = new long[] { 1, 2, 3, 4, 5 };
                list = new Calculation(m);
                //list = Calc2(m);
                var l = new List<long>();
                l.AddRange(list);
                l.AddRange(new long[] { 1, 2, 3, 4, 5 });
                Console.WriteLine(string.Join(", ", l));
                foreach (var z in list)
                {
                    Console.WriteLine($"{j++} {z:N0}");
                }

                #region foreach implementation
                j = 1;
                IEnumerator<long> enumerator = list.GetEnumerator();
                while(enumerator.MoveNext())
                {
                    long value = enumerator.Current;
                    Console.WriteLine($"{j++} {value:N0}");
                }
                #endregion
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("The number of trailing digits is out of range.");
                return;
            }

        }

        static List<long> Calc(int m)
        {
            if (m < 1 || m > 17)
            {
                throw new ArgumentOutOfRangeException(nameof(m));
            }
            long x = 1;
            // int m = 3;
            long d = 1;
            for (int i = 0; i < m; i++)
            {
                d = d * 10;
            }
            // when m is 3, d = 1000.
            var list = new List<long>();
            var exists = new Dictionary<long, bool>();
            for (int i = 1; ; i++)
            {
                x = x * 2;
                long y = x = x % d;
                if (exists.ContainsKey(y))
                {
                    break;
                }
                exists.Add(y, true);
                exists[y] = true;
                list.Add(y);
                // Console.WriteLine($"{y:N0}");
            }
            return list;
        }

        static IEnumerable<long> Calc2(int m)
        {
            if (m < 1 || m > 17)
            {
                throw new ArgumentOutOfRangeException(nameof(m));
            }
            long x = 1;
            // int m = 3;
            long d = 1;
            for (int i = 0; i < m; i++)
            {
                d = d * 10;
            }
            // when m is 3, d = 1000.
            var exists = new Dictionary<long, bool>();
            for (int i = 1; ; i++)
            {
                x = x * 2;
                long y = x = x % d;
                if (exists.ContainsKey(y))
                {
                    yield break;
                }
                exists.Add(y, true);
                exists[y] = true;
                yield return y; // it returns the value of y on demand.
                // Console.WriteLine($"{y:N0}");
            }
        }

       
    }
}
