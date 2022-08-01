using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null.FuncDraw.Utils
{
    internal class NumUtil
    {
        public static int RandomInt(int min, int max)
        {
            return new Random(Guid.NewGuid().GetHashCode()).Next(min, max);
        }
        public static IEnumerable<double> Range(double start, double stop, double step)
        {
            for (double i = start; i < stop; i += step)
                yield return i;
        }
    }
}
