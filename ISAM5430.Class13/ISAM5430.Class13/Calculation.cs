using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculation : IEnumerable<long>
    {
        private int m;
        public Calculation(int m)
        {
            this.m = m;
        }
        public IEnumerator<long> GetEnumerator()
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
