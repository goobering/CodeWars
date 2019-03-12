using System;
using System.Collections.Generic;

namespace Src
{
    public static class Kata
    {
        public static long PowerSumDigTerm(int n) 
        {
            List<long> a = new List<long>();
             
            for (int b = 2; b < 400; b++) {
                long value = b;
                for (int e = 2; e < 50; e++) {
                    value *= b;
            
                    if (DigitSum(value) == b) {
                        a.Add(value);            
                    }
                    if (a.Count > 50) break;                    
                }
                if (a.Count > 50) break;                    
            }

            a.Sort();

            foreach(var v in a)
            {
                Console.WriteLine(v);
            }
            return a[n - 1];
        }

        private static long DigitSum(long n) 
        {
            long sum = 0;
            while (n > 0) {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }
    }
}
