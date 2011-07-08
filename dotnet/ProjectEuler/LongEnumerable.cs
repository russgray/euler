using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    public static class LongEnumerable
    {
        public static IEnumerable<long> Range(long start, long count)
        {
            return Longs(start, 1).Take((int) count);
        }

        public static IEnumerable<long> Longs(long start, long step)
        {
            for (long i = start;; i += step)
                yield return i;
        }
    }
}