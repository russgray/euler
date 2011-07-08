using System;
using System.Collections.Generic;

namespace Euler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var problems = new List<IEulerProblem>()
                                               {
                                                   //new Euler01(),
                                                   //new Euler02(),
                                                   //new Euler03(),
                                                   //new Euler04(),
                                                   //new Euler05(),
                                                   //new Euler06(),
                                                   //new Euler07(),
                                                   //new Euler08(),
                                                   //new Euler09(),
                                                   //new Euler10(),
                                                   new Euler11(),
                                               };

            problems.ForEach(p => p.Solve());
            Console.ReadKey();
        }
    }
}