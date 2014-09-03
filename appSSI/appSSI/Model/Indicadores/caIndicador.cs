using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caIndicador
    {
        public string nmTabela
        {
            get { return "INDICADORES"; }
        }

        public string nmCampoChave
        {
            get { return "cdIndicador"; }
        }

        public string cdIndicador
        {
            get { return "cdIndicador"; }
        }

        public string cdDefeito
        {
            get { return "cdDefeito"; }
        }

        public string cdUsuario
        {
            get { return "cdUsuario"; }
        }

        public string cdSolucao
        {
            get { return "cdSolucao"; }
        }

        public string flResultado
        {
            get { return "flResultado"; }
        }

        public string deObservacao
        {
            get { return "deObservacao"; }
        }

        public string cdOSGerada
        {
            get { return "cdOSGerada"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdIndicador + "," + cdUsuario + "," + cdDefeito + "," + cdSolucao + "," + flResultado + "," + deObservacao + "," + cdOSGerada;

            strNome = "Código, Usuário, Defeito, Solução, Resultado, Observação, Cód. OS Task";

            strVisivel = "0,0,0,0,0,0,0";
        }
    }
}
