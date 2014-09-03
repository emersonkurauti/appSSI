using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caParametros
    {
        public string nmTabela
        {
            get { return "PARAMETROS"; }
        }

        public string nmCampoChave
        {
            get { return "cdParametro"; }
        }

        public string cdParametro
        {
            get { return "cdParametro"; }
        }

        public string cdIndicador
        {
            get { return "cdIndicador"; }
        }

        public string nmParametro
        {
            get { return "nmParametro"; }
        }

        public string vlParametro
        {
            get { return "vlParametro"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdParametro + "," + cdIndicador + "," + nmParametro + "," + vlParametro;

            strNome = "Código, Indicador, Parâmetro, Valor";

            strVisivel = "0,0,0,0";
        }
    }
}
