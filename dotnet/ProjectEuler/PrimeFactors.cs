using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler
{
    public static class PrimeFactors
    {
        // Find all prime factors.
        public static IEnumerable<long> Factors(long number)
        {
            // Start by removing the lowest prime (2)
            return MorePrimeFactors(number, 2);
        }

        // This recursive method finds all prime factors.
        private static IEnumerable<long> MorePrimeFactors(long number, int factor)
        {
            // Find the next prime factor
            while (number%factor != 0)
                factor++;

            // Return it.
            yield return factor;

            // look again...
            if (number > factor)
                // recursively look for this factor again, using Num/factor
                // as the new big number
                foreach (long factors in MorePrimeFactors(number/factor, factor))
                    yield return factors;
        }
    }

    //public static class InfiniteLists
    //{
    //    public static IEnumerable<long> Integers()
    //    {
    //        long current = 0;
    //        while (true)
    //        {
    //            yield return ++current;
    //        }
    //    }

    //    public static IEnumerable<long> Primes()
    //    {
    //        var primes = from i in Integers() 
    //                     where i > 1L && i % 2 != 0 && i % 3 != 0 && i % 5 != 0
    //                     select i;

    //        while (true)
    //        {
    //            var prime = primes.First();
    //            yield return prime;
    //            primes = from p in primes where (p % prime) > 0L select p;
    //        }
    //    }
    //}
}