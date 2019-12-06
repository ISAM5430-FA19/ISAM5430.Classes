using System;
using System.Collections.Generic;

namespace ISAM5430.Class14
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int>, Stack<int>, Queue<int>, int[], IList<int>, ICollection<int>, IEnumerable<int>, IReadOnlyCollection<int>, IReadOnlyList<int>.
            // Dictionary<K,V> : IDictionary<K,V>; IReadOnlyDictionary<K,V>
            int[] x = new int[] { 0, 2, 1, 2, -3, -2, 2 };
            List<int> xlist = new List<int> { 1, 2, 3, 4, 5 };
            
            IList<IList<int>> collection = new IList<int>[] { x, xlist };

            int sum = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                sum = sum + Sum(collection[i]);
            }
            Console.WriteLine(sum);

            Console.WriteLine(Sum(x));
            Console.WriteLine(Sum(xlist));


            for (int firstIndex= 0; firstIndex < x.Length; firstIndex ++)
            {
                for (int lastIndex = firstIndex + 1; lastIndex < x.Length; lastIndex++)
                {
                    Console.Write(firstIndex + ", " + lastIndex + ": ");

                    var subarray = SubArray(x, firstIndex, lastIndex);

                    Console.WriteLine(string.Join(", ", subarray));
                }
                Console.WriteLine();
            }
        }

        static List<int> SubArray(int[] x, int firstIndex, int lastIndex)
        {
            List<int> subarray = new List<int>();
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                subarray.Add(x[i]);
            }
            return subarray;
        }

        static int Sum(IList<int> x)
        {
            int sum = 0;
            for (int i = 0; i < x.Count; i++)
            {
                sum = sum + x[i];
            }
            return sum;
        }
    }
}

