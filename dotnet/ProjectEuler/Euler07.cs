using System;
using System.Linq;

namespace Euler
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
    /// we can see that the 6th prime is 13.
    /// 
    /// What is the 10001st prime number?
    /// </summary>
    public class Euler07 : IEulerProblem
    {
        #region IEulerProblem Members

        public void Solve()
        {
            var sieve = SieveOfEratosthenes.CreateSieveWithAtLeastNPrimes(10001);
            var result = sieve.Primes().Take(10001).Last();

            Console.WriteLine(GetType() + ": " + result);
        }

        #endregion
    }
}