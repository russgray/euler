using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Euler
{
    public class SieveOfEratosthenes
    {
        private readonly bool[] m_numbers;

        public SieveOfEratosthenes(long limit)
        {
            m_numbers = new bool[limit + 1];
            for (long l = 2; l < m_numbers.LongLength; ++l)
            {
                m_numbers[l] = true;
            }

            for (int i = 2;
                 i != -1;
                 i = Array.FindIndex(m_numbers, i + 1, b => b))
            {
                for (int j = i*2; j < m_numbers.Length; j += i)
                    m_numbers[j] = false;
            }
        }

        public static SieveOfEratosthenes CreateSieveWithAtLeastNPrimes(int n)
        {
            return new SieveOfEratosthenes((long) Math.Ceiling(UpperBoundEstimate(n)));
        }

        public static SieveOfEratosthenes CreateSieveWithUpperBound(long limit)
        {
            return new SieveOfEratosthenes(limit);
        }

        public IEnumerable<long> Primes()
        {
            for (long i = 2; i < m_numbers.LongLength; ++i)
                if (m_numbers[i])
                    yield return i;
        }

        private static double UpperBoundEstimate(int n)
        {
            return n * Ln(n) + n * (Ln(Ln(n)) - 0.9385);
        }

        private static double UpperBoundEstimate2(int n)
        {
            return n * Ln(n) + n * (Ln(Ln(n)));
        }

        private static double Ln(double n)
        {
            return Math.Log(n, Math.E);
        }
    }
}