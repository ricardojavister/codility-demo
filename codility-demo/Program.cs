using System;
using System.Linq;

namespace codility_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int res = 1;
            A = A.OrderBy(x => x).ToArray();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0)
                    continue;
                else if (A[i] == res)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
