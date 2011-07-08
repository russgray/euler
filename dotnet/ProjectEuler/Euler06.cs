using System;
using System.Linq;

namespace Euler
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1² + 2² + ... + 10² = 385
    /// 
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)² = 55² = 3025
    /// 
    /// Hence the difference between the sum of the squares of the first 
    /// ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// 
    /// Find the difference between the sum of the squares of the first 
    /// one hundred natural numbers and the square of the sum.
    /// </summary>
    public class Euler06 : IEulerProblem
    {
        #region IEulerProblem Members

        public void Solve()
        {
            var sqsum = Enumerable.Range(1, 100).Sum().Square();
            var sumsq = Enumerable.Range(1, 100).Aggregate(0, (curr, next) => curr + (int) next.Square());

            Console.WriteLine(GetType() + ": " + (sqsum - sumsq));
        }

        #endregion
    }
}