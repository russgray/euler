using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    public class Euler10 : IEulerProblem
    {
        #region IEulerProblem Members

        public void Solve()
        {
            /* ans: 142,913,828,922
             * long.MaxValue   9,223,372,036,854,775,807
             * ulong.MaxValue  18,446,744,073,709,551,615
             */
            var sieve = new SieveOfEratosthenes(2000000);
            var result = sieve.Primes().Sum();
            Console.WriteLine(GetType() + ": " + result);
        }

        #endregion
    }
}