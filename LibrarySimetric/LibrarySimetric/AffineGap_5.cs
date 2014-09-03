using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySimetric
{
    class AffineGap_5
    {
        public float getCost(string stringToGap, int stringIndexStartGap, int stringIndexEndGap)
        {
            if (stringIndexStartGap >= stringIndexEndGap)
            {
                return 0.0f;
            }
            else
            {
                return 5.0f + ((stringIndexEndGap - 1) - stringIndexStartGap);
            }
        }

        public float getMaxCost()
        {
            return 5.0f;
        }

        public float getMinCost()
        {
            return 0.0f;
        }
    }
}
