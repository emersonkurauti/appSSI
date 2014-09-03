using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caSolucoesDefeitos
    {
        public string nmTabela
        {
            get { return "SOLUCOES_DEFEITOS"; }
        }

        private string _nmCampoChave;
        public string nmCampoChave
        {
            get { return _nmCampoChave; }
            set { _nmCampoChave = value; }
        }

        public string cdDefeito
        {
            get { return "cdDefeito"; }
        }

        public string cdSolucao
        {
            get { return "cdSolucao"; }
        }

        public string CC_deSolucao
        {
            get { return "CC_deSolucao"; }
        }

        public string CC_deDefeito
        {
            get { return "CC_deDefeito"; }
        }

        public string deObservacao
        {
            get { return "deObservacao"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdDefeito + "," + cdSolucao + "," + deObservacao;

            strNome = "Defeito, Solução, Observação";

            strVisivel = "0,0,1";
        }
    }
}
