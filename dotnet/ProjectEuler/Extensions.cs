using System;
using System.Collections.Generic;

namespace Euler
{
    public static class Extensions
    {
        public static ulong Sum(this IEnumerable<ulong> ulongs)
        {
            ulong result = 0;
            foreach (ulong ul in ulongs)
            {
                result += ul;
            }
            return result;
        }

        public static string Reverse(this string s)
        {
            char[] ch = s.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }

        public static bool IsPalindrome(this string s)
        {
            return s == s.Reverse();
        }

        public static long Square(this int n)
        {
            return n*n;
        }

        public static long GCD(this long a, long b)
        {
            while (b != 0)
            {
                long tmp = b;
                b = a%b;
                a = tmp;
            }

            return a;
        }

        public static long LCM(this long a, long b)
        {
            return (a*b)/a.GCD(b);
        }
    }
}