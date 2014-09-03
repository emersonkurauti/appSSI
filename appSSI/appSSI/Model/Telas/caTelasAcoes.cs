using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caTelasAcoes
    {
        public string nmTabela
        {
            get { return "TELAS_ACOES"; }
        }

        public string nmCampoChave
        {
            get { return "cdTela"; }
        }

        public string cdTela
        {
            get { return "cdTela"; }
        }

        public string cdAcao
        {
            get { return "cdAcao"; }
        }

        public string CC_deAcao
        {
            get { return "CC_deAcao"; } 
        }

        /// <summary>
        /// Retorna os fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdTela + "," + cdAcao + "," + CC_deAcao;

            strNome = "Código Tela, Código Ação, Ação";

            strVisivel = "0,0,1";
        }
    }
}
