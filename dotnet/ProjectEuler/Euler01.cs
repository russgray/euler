using System;
using System.Linq;

namespace Euler
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples 
    /// of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 
    /// 23. 
    /// 
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Euler01 : IEulerProblem
    {
        #region IEulerProblem Members

        public void Solve()
        {
            Console.WriteLine(GetType() + ": " + LinqSolver());
            //Console.WriteLine(GetType() + ": " + LinqSolver2());
            //Console.WriteLine(GetType() + ": " + LinqSolver3());
            //Console.WriteLine(GetType() + ": " + LoopSolver());
        }

        #endregion

        private static int LinqSolver()
        {
            return (from n in Enumerable.Range(1, 999)
                    where n%3 == 0 || n%5 == 0
                    select n).Sum();
        }

        private static int LinqSolver2()
        {
            return Enumerable.Range(1, 999).Where(f => f%3 == 0 || f%5 == 0).Sum();
        }

        private static int LinqSolver3()
        {
            return Enumerable.Range(1, 999).Where(f => f%3*f%5 == 0).Sum();
        }

        private static int LoopSolver()
        {
            int result = 0;
            for (int i = 0; i < 1000; ++i)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}