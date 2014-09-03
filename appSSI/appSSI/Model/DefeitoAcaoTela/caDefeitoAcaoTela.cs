using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caDefeitoAcaoTela
    {
        public string nmTabela
        {
            get { return "TELAS_DEFEITOS"; }
        }

        public string nmCampoChave
        {
            get { return "cdDefeito"; }
        }

        public string cdAcao
        {
            get { return "cdAcao"; }
        }

        public string cdTela
        {
            get { return "cdTela"; }
        }

        public string cdDefeito
        {
            get { return "cdDefeito"; }
        }

        public string CC_deAcao
        {
            get { return "CC_deAcao"; }
        }

        public string CC_deTela
        {
            get { return "CC_deTela"; }
        }

        public string CC_deDefeito
        {
            get { return "CC_deDefeito"; }
        }
        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdAcao + "," + cdTela + "," + cdDefeito + "," + CC_deAcao + "," + CC_deTela + "," + CC_deDefeito;

            strNome = "Código Ação, Código Tela, Código Defeito, Ação, Tela, Defeito";

            strVisivel = "0,0,0,1,1,1";
        }
    }
}
