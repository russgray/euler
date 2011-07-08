using System;
using System.Linq;

namespace Euler
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// 
    /// What is the largest prime factor of the number 600,851,475,143?
    /// </summary>
    public class Euler03 : IEulerProblem
    {
        private const long NUM = 600851475143;
        //const long NUM = 1000;

        #region IEulerProblem Members

        public void Solve()
        {
            Console.WriteLine(GetType() + ": " + SieveSolver());
            Console.WriteLine(GetType() + ": " + BruteForceSolver());
        }

        #endregion

        private static long SieveSolver()
        {
            var sieve = new SieveOfEratosthenes((long) Math.Sqrt(NUM));
            //var sieve = new SieveOfEratosthenes(50000);
            return (from p in sieve.Primes()
                    where NUM%p == 0
                    select p).Max();
        }

        private static long BruteForceSolver()
        {
            return PrimeFactors.Factors(NUM).Max();
        }
    }
}