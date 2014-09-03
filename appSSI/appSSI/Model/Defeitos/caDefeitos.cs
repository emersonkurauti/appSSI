using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caDefeitos
    {
        public string nmTabela
        {
            get { return "DEFEITOS"; }
        }

        public string nmCampoChave
        {
            get { return "cdDefeito"; }
        }

        public string cdDefeito
        {
            get { return "cdDefeito"; }
        }

        public string deDefeito
        {
            get { return "deDefeito"; }
        }

        public string flEstagio
        {
            get { return "flEstagio"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdDefeito + "," + deDefeito + "," + flEstagio;

            strNome = "Código, Defeito, Estágio";

            strVisivel = "0,1,1";
        }
    }
}
