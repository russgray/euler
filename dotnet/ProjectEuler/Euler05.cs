using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Euler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers 
    /// from 1 to 10 without any remainder.
    /// 
    /// What is the smallest number that is evenly divisible by all of the 
    /// numbers from 1 to 20?
    /// </summary>
    public class Euler05 : IEulerProblem
    {
        #region IEulerProblem Members

        public void Solve()
        {
            //http://www.research.att.com/~njas/sequences/A003418
            //var seq = Enumerable.Range(1, 20).Select(
            //    x => LongEnumerable.Range(1, x).Aggregate(1L, (curr, next) => curr.LCM(next)));

            Console.WriteLine(GetType() + ": " + BruteForceSolver1());
            Console.WriteLine(GetType() + ": " + FunkySolver());
        }

        #endregion

        private long BruteForceSolver1()
        {
            long result;
            for (result = 2520; !Check(result); result += 2520)
                ;
            return result;
        }

        private long FunkySolver()
        {
            return LongEnumerable.Range(1, 20).Aggregate(1L, (curr, next) => curr.LCM(next));
        }

        private bool Check(long result)
        {
            for (int i = 11; i <= 20; i++)
            {
                if (result%i != 0)
                    return false;
            }

            return true;
        }
    }
}