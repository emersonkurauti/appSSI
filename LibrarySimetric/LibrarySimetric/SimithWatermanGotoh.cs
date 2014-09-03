using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySimetric
{
    class SimithWatermanGotoh
    {
        private int windowSize;

        public int WindowSize
        {
            get { return windowSize; }
            set { windowSize = value; }
        }

        private AffineGap_5 gGapFunc;

        internal AffineGap_5 GapFunc
        {
            get { return gGapFunc; }
            set { gGapFunc = value; }
        }
        private SubCost5_3_Minus3 dCostFunc;

        internal SubCost5_3_Minus3 CostFunc
        {
            get { return dCostFunc; }
            set { dCostFunc = value; }
        }

        public SimithWatermanGotoh()
        {
            gGapFunc = new AffineGap_5();
            dCostFunc = new SubCost5_3_Minus3();
            windowSize = int.MaxValue;
        }

        public float getSimilarity(string string1, string string2)
        {
            float smithWatermanGotoh = getUnNormalisedSimilarity(string1, string2);

            float maxValue = Math.Min(string1.Length, string2.Length);

            if (dCostFunc.getMaxCost() > -gGapFunc.getMaxCost())
            {
                maxValue *= dCostFunc.getMaxCost();
            }
            else
            {
                maxValue *= -gGapFunc.getMaxCost();
            }

            if (maxValue == 0)
            {
                return 0.0f;
            }
            else
            {
                return (smithWatermanGotoh / maxValue);
            }
        }

        public float getUnNormalisedSimilarity(string s, string t)
        {
            float[,] d;
            int n, m, i, j;
            float cost;

            n = s.Length;
            m = t.Length;

            if (n == 0)
            {
                return m;
            }
            if (m == 0)
            {
                return n;
            }

            d = new float[n, m];

            float maxSoFar = 0.0f;

            for (i = 0; i < n; i++)
            {
                cost = dCostFunc.getCost(s, i, t, 0);

                if (i == 0)
                {
                    d[0, 0] = Math.Max(0, cost);
                }
                else
                {
                    float maxGapCost = 0.0f;
                    int windowStart = i - windowSize;
                    if (windowStart < 1)
                    {
                        windowStart = 1;
                    }

                    for (int k = windowStart; k < i; k++)
                    {
                        maxGapCost = Math.Max(maxGapCost, d[i - k, 0] - gGapFunc.getCost(s, i - k, i));
                    }

                    d[i, 0] = MathFuncs.max3(0, maxGapCost, cost);
                }

                if (d[i, 0] > maxSoFar)
                {
                    maxSoFar = d[i, 0];
                }
            }

            for (j = 0; j < m; j++)
            {
                cost = dCostFunc.getCost(s, 0, t, j);

                if (j == 0)
                {
                    d[0, 0] = Math.Max(0, cost);
                }
                else
                {
                    float maxGapCost = 0.0f;
                    int windowStart = j - windowSize;

                    if (windowStart < 1)
                    {
                        windowStart = 1;
                    }

                    for (int k = windowStart; k < j; k++)
                    {
                        maxGapCost = Math.Max(maxGapCost, d[0, j - k] - gGapFunc.getCost(t, j - k, j));
                    }

                    d[0,j] = MathFuncs.max3(0, maxGapCost, cost);
                }

                if (d[0, j] > maxSoFar)
                {
                    maxSoFar = d[0, j];
                }
            }

            for (i = 1; i < n; i++)
            {
                for (j = 1; j < m; j++)
                {

                    cost = dCostFunc.getCost(s, i, t, j);

                    float maxGapCost1 = 0.0f;
                    float maxGapCost2 = 0.0f;
                    int windowStart = i - windowSize;

                    if (windowStart < 1)
                    {
                        windowStart = 1;
                    }

                    for (int k = windowStart; k < i; k++)
                    {
                        maxGapCost1 = Math.Max(maxGapCost1, d[i - k, j] - gGapFunc.getCost(s, i - k, i));
                    }

                    windowStart = j - windowSize;
                    if (windowStart < 1)
                    {
                        windowStart = 1;
                    }

                    for (int k = windowStart; k < j; k++)
                    {
                        maxGapCost2 = Math.Max(maxGapCost2, d[i, j - k] - gGapFunc.getCost(t, j - k, j));
                    }

                    d[i,j] = MathFuncs.max4(0, maxGapCost1, maxGapCost2, d[i - 1,j - 1] + cost);

                    if (d[i, j] > maxSoFar)
                    {
                        maxSoFar = d[i, j];
                    }
                }
            }

            return maxSoFar;
        }
    }
}
