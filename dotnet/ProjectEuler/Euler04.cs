using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    public class Euler04 : IEulerProblem
    {
        #region IEulerProblem Members

        public void Solve()
        {
            var result = (from product in AllProducts.From(100).To(999)
                          where product.ToString().IsPalindrome()
                          select product).Max();
            Console.WriteLine(GetType() + ": " + result);
        }

        #endregion

        private class AllProducts
        {
            private int m_from;

            private AllProducts(int @from)
            {
                m_from = @from;
            }

            public static AllProducts From(int @from)
            {
                return new AllProducts(@from);
            }

            public IEnumerable<int> To(int @to)
            {
                int inclusiveTo = @to + 1; // @to is inclusive

                return from i in Enumerable.Range(m_from, inclusiveTo - m_from)
                       from j in Enumerable.Range(i, inclusiveTo - i)
                       select i*j;
            }
        }
    }
}