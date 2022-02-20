using System;

namespace Fibonaci
{
    class Program
    {
        static int FibonaciR(int N) {
            if (N == 0) return 0;
            if (N == 1) return 1;
            return FibonaciR( N - 1 ) + FibonaciR( N - 2 );

        
        }
        static int FibonaciI(int N) {
            int fib0 = 0;
            int fib1 = 1;
            if (N == 0) return fib0;
            if (N == 1) return fib1;
            int counter = 1;
            int first, last;

            first = fib0;
            last = fib1;

            
            while (counter < N) {
                int tmp = last;
                last = first + last;
                first = tmp;
                counter++;
            }
            return last;

        
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                int fib = FibonaciR(i);
                Console.WriteLine($"i: {i} {fib}");
            }

            for (int i = 0; i < 9; i++) {
                int fibi = FibonaciI(i);
                Console.WriteLine($"i: {i} {fibi}");
            }
        }
    }
}
