using System;

namespace Prime
{
    class Program
    {
        static bool isPrime(int k) {
            bool flIsPrime = true;
            for (int i = 2; i < k; i++)
            {

           
                if ((i != k) && (k % i) == 0)
                {
                    flIsPrime = false;
                    return flIsPrime;
                }
            }
            return flIsPrime;
        }
        
        static int findPrimes(int N) {
            int num = 0;
            for (int i = 2; i < N ; i++) {
              
                if ( isPrime(i) )
                {
                    Console.WriteLine($"Prime: {i}");                
                    num++;
                }
                else {
                  
                }
               
                
            }
            return num;
        }
        static void Main(string[] args)
        {
            int N = 12;
            int num_primes = findPrimes(N);
            Console.WriteLine($"Num primes less than {N}");
            if (findPrimes(20) != 8) {
                Console.WriteLine("Error!");
            }
        }
    }
}
