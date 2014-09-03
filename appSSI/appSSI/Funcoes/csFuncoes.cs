using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Banco;

namespace appSSI
{
    public class csFuncoes
    {

        public void ConverStringtArrayList(string str, out ArrayList al, char cSeparador)
        {
            ArrayList alLista = new ArrayList();
            string[] vstr;
            vstr = str.Split(cSeparador);

            foreach (string s in vstr)
            {
                alLista.Add(s);
            }

            al = alLista;
        }

        public string FormatarCNPJ(string strCNPJ)
        {
            strCNPJ = CharFill(strCNPJ, '0', 14);

            strCNPJ = strCNPJ.ToString().Substring(0, 2) + '.' +
                      strCNPJ.ToString().Substring(2, 3) + '.' +
                      strCNPJ.ToString().Substring(5, 3) + '/' +
                      strCNPJ.ToString().Substring(8, 4) + '-' +
                      strCNPJ.ToString().Substring(12, 2);

            return strCNPJ;
        }

        public string CharFill(string strFrase, char cCaracter, int nTamanho, bool bAntes = true)
        {
            if (strFrase.Length < nTamanho)
            {
                while (strFrase.Length < nTamanho)
                {
                    if (bAntes)
                        strFrase = cCaracter.ToString() + strFrase;
                    else
                        strFrase = strFrase + cCaracter.ToString();
                }
            }

            return strFrase;
        }
    }
}
