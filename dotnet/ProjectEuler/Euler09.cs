using System;
using System.Linq;

namespace Euler
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a&lt;b&lt;c, for which,
    /// a² + b² = c²
    /// 
    /// For example, 3² + 4² = 9 + 16 = 25 = 5².
    /// 
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class Euler09 : IEulerProblem
    {
        #region IEulerProblem Members

        public void Solve()
        {
            Console.WriteLine(GetType() + ": " + LinqSolver());
            //Console.WriteLine(GetType() + ": " + LoopSolver());
        }

        #endregion

        #region Solvers

        private static int LinqSolver()
        {
            /*
             * Trimming the search space:
             * c = 1000 - a - b, so don't have to enumerate for c
             * a<b, so only enumerate b from a rather than 1
             * a<1000/3, since a<b<c
             * b<500, since b<c and a+b+c!=1000 where b>=500 (since
             * that would require c>500 which takes us over 1000 
             * without even counting a)
             * 
             * http://www.fsharp.it/2008/01/25/project-euler-in-f-problem-9/
             */
            var triplet = (from a in Enumerable.Range(1, 334)
                           from b in Enumerable.Range(a, 500 - a)
                           where a.Square() + b.Square() == (1000 - a - b).Square()
                           select new {A = a, B = b, C = (1000 - a - b)})
                .First();

            var result = triplet.A*triplet.B*triplet.C;
            return result;
        }

        private static int LoopSolver()
        {
            // Brute-force nastiness
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    for (int c = 1; c < 1000; c++)
                    {
                        if (a + b + c == 1000 && a.Square() + b.Square() == c.Square())
                        {
                            return a*b*c;
                        }
                    }
                }
            }

            // Not found
            return -1;
        }

        #endregion

        private static long Square(int x)
        {
            return x*x;
        }
    }
}