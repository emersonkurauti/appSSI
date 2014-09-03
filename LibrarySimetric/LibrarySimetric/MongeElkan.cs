using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LibrarySimetric
{
    public class MongeElkan
    {
        //Método Monge Elkan
        public float getSimilarityMongeElkan(string strFrase1, string strFrase2)
        {
            SimithWatermanGotoh objMetodoGotoh = new SimithWatermanGotoh();
            string[] str1Tokens = strFrase1.ToString().Split(' ');
            string[] str2Tokens = strFrase2.ToString().Split(' ');

            ArrayList al1Tokens = new ArrayList();
            ArrayList al2Tokens = new ArrayList();

            for (int i = 0; i < str1Tokens.Length; i++)
                al1Tokens.Add(str1Tokens[i]);

            for (int i = 0; i < str2Tokens.Length; i++)
                al2Tokens.Add(str2Tokens[i]);

            float sumMatches = 0.0f;
            float maxFound;

            foreach (string str1Token in al1Tokens)
            {
                maxFound = 0.0f;
                foreach (string str2Token in al2Tokens)
                {
                    float found = objMetodoGotoh.getSimilarity(str1Token, str2Token);

                    if (found > maxFound)
                    {
                        maxFound = found;
                    }
                }
                sumMatches += maxFound;
            }
            return sumMatches / (float)al1Tokens.Count;
        }
    }
}
