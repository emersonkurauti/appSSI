using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySimetric
{
    class MathFuncs
    {
        public static float max3(float x, float y, float z)
        {
            return Math.Max(x, Math.Max(y, z));
        }

        public static float max4(float w, float x, float y, float z)
        {
            return Math.Max(Math.Max(w, x), Math.Max(y, z));
        }
    }
}
