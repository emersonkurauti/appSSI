using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caSolucoes
    {
        public string nmTabela
        {
            get { return "SOLUCOES"; }
        }

        public string nmCampoChave
        {
            get { return "cdSolucao"; }
        }

        public string cdSolucao
        {
            get { return "cdSolucao"; }
        }

        public string deSolucao
        {
            get { return "deSolucao"; }
        }

        public string flNivel
        {
            get { return "flNivel"; }
        }

        public string dtCadastro
        {
            get { return "dtCadastro"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdSolucao + "," + deSolucao + "," + flNivel + "," + dtCadastro;

            strNome = "Código, Solução, Nível, Dt. Cadastro";

            strVisivel = "0,1,1,1";
        }
    }
}
