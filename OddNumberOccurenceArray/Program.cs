using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberOccurenceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            int [] chk = new int[] { 7, 3, 9, 3, 9, 7, 9,5 };
            Console.WriteLine(sl.solution(chk));
            Console.ReadLine();
            Console.ReadKey();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for(int i=0;i<A.Length;i++)
            {
                int k = 0;
                k = A[i];
                for(int p=0;p<A.Length;p++)
                {
                    if(i!=p)
                    {
                        if(k==A[p])
                        {
                            A[p] = 0;
                            A[i] = 0;
                        }
                    }
                }
            }

            int res = 0;
            foreach (var val in A)
            {
                if(val!=0)
                {
                    res = val;
                }
            }
            return res;
        }
    }
}
