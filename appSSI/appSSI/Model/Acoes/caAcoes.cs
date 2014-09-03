using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caAcoes
    {
        public string nmTabela
        {
            get { return "ACOES"; }
        }

        public string nmCampoChave
        {
            get { return "cdAcao"; }
        }

        public string cdAcao
        {
            get { return "cdAcao"; }
        }

        public string deAcao
        {
            get { return "deAcao"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdAcao + "," + deAcao;

            strNome = "Código, Ação";

            strVisivel = "0,1";
        }
    }
}
