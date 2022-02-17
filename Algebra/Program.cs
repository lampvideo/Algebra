using System;

namespace Algebra
{
    class Program
    {
        static int pow(int a, int N) { 
            if (a == 1 ) return 1;
            if (N == 0) return 1;
            int d = a;
            int accumulator = 1;
            //если степень >=2, Т.е. как минимум один квадрат у нас есть
            while (N  > 1) {
                
                if (N % 2 == 1)
                {
                    accumulator *= d;
                }
                N /= 2;
                d *= d;
                Console.WriteLine($"d: {d} n: {N} acc: {accumulator}") ;
            }
            return accumulator * d;
        }
        static void Main(string[] args)
        {
            int result = pow(3, 4);
            if (result == 81) {
                Console.WriteLine("Passed!");
            }
            result = pow(2, 9);
            if (result == 512)
            {
                Console.WriteLine("Passed!");
            }

            result = pow(3, 3);
            if (result == 27) {
                Console.WriteLine("Passed!");
            }

            Console.WriteLine(result);
        }
    }
}
