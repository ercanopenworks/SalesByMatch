using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
        }

        private static int sockMerchant(int n, List<int> ar)
        {
            var pileCount = 0;
            var set = new HashSet<int>();
            foreach(var item in ar)
            {
                if (!set.Contains(item))
                {
                    set.Add(item);
                }
                else
                {
                    pileCount++;
                    set.Remove(item);
                }

            }

            return pileCount;
        }
    }
}
