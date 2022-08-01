using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null.FuncDraw.Utils
{
    internal class ColorUtil
    {
        public static int Color2Int(Color color)
        {
            return color.R | color.G << 8 | color.B << 16;
        }
    }
}
