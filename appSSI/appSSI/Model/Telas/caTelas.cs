using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caTelas
    {
        public string nmTabela
        {
            get { return "TELAS"; }
        }

        public string nmCampoChave
        {
            get { return "cdTela"; }
        }

        public string cdTela
        {
            get { return "cdTela"; }
        }

        public string cdModulo
        {
            get { return "cdModulo"; }
        }

        public string nmTela
        {
            get { return "nmTela"; }
        }

        #region Campos Calculados

        public string CC_nmModulo
        {
            get { return "CC_nmModulo"; }
        }

        #endregion

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdTela + "," + cdModulo + "," + nmTela + "," + CC_nmModulo;

            strNome = "Código, Código Módulo, Descrição, Módulo";

            strVisivel = "0,0,1,1";
        }
    }
}
