using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LibrarySimetric
{
    class SubCost5_3_Minus3
    {
        private static int CHAR_EXACT_MATCH_SCORE = +5;

        private static int CHAR_APPROX_MATCH_SCORE = +3;

        private static int CHAR_MISMATCH_MATCH_SCORE = -3;

        private ArrayList approx;

        public SubCost5_3_Minus3()
        { 
            HashSet<char> vet;
            approx = new ArrayList();

            vet = new HashSet<char>();
            vet.Add('d');
            vet.Add('t');
            approx.Add(vet);

            vet = new HashSet<char>();
            vet.Add('g');
            vet.Add('j');
            approx.Add(vet);

            vet = new HashSet<char>();
            vet.Add('l');
            vet.Add('r');
            approx.Add(vet);

            vet = new HashSet<char>();
            vet.Add('m');
            vet.Add('n');
            approx.Add(vet);

            vet = new HashSet<char>();
            vet.Add('b');
            vet.Add('p');
            vet.Add('v');
            approx.Add(vet);

            vet = new HashSet<char>();
            vet.Add('a');
            vet.Add('e');
            vet.Add('i');
            vet.Add('o');
            vet.Add('u');
            approx.Add(vet);

            vet = new HashSet<char>();
            vet.Add(',');
            vet.Add('.');
            approx.Add(vet);
        }

        public float getCost(string str1, int string1Index, string str2, int string2Index)
        {
            if (str1.Length <= string1Index || string1Index < 0)
            {
                return CHAR_MISMATCH_MATCH_SCORE;
            }
            if (str2.Length <= string2Index || string2Index < 0)
            {
                return CHAR_MISMATCH_MATCH_SCORE;
            }

            if (str1[string1Index] == str2[string2Index])
            {
                return CHAR_EXACT_MATCH_SCORE;
            }
            else
            {
                char si = str1.ToLower()[string1Index];
                char ti = str2.ToLower()[string2Index];
                foreach (HashSet<char> aApprox in approx) {
                    if (aApprox.Contains(si) && aApprox.Contains(ti))
                        return CHAR_APPROX_MATCH_SCORE;
                }
                return CHAR_MISMATCH_MATCH_SCORE;
            }
        }

        public float getMaxCost()
        {
            return CHAR_EXACT_MATCH_SCORE;
        }

        public float getMinCost()
        {
            return CHAR_MISMATCH_MATCH_SCORE;
        }
    }
}
