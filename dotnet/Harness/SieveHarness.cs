using System;
using System.Linq;
using Euler;
using NUnit.Framework;

namespace Harness
{
    [TestFixture]
    public class SieveHarness
    {
        [Test]
        public void TestNthPrime()
        {
            foreach (int n in new[]
                {
                    38127, 79433, 14227, 17113, 45669,
                    35291, 74927, 9812, 84318, 19210,
                    33082, 38562, 20945, 96449, 48510,
                    78196, 33352, 74295, 76342, 50735,
                    34084, 6162, 41060, 12474, 51064
                })
            {
                SieveOfEratosthenes sieve = SieveOfEratosthenes.CreateSieveWithAtLeastNPrimes(n);
                long ans = sieve.Primes().Take(n).Last();
                Console.WriteLine("{0},{1},{2}", ans, n, sieve.Primes().Count());
                //Console.WriteLine("({0},{1}),", n, ans);
            }
        }

        [Test]
        public void TestSieveSum()
        {
            foreach (int n in new[]
                {
                    1234, 23864, 15892, 10953, 9113,
                    8852, 24049, 12318, 24606, 9065,
                    1806, 18358, 19330, 9866, 8792,
                    14852, 5287, 14560, 25234, 29748,
                    15579, 174, 8924, 10325, 23220,
                })
            {
                var sieve = new SieveOfEratosthenes(n);
                //Console.WriteLine("{0},{1}", sieve.Primes().Sum(), sieve.Primes().Count());
                Console.WriteLine("({0},{1}),", n, sieve.Primes().Sum());
            }
        }
    }
}