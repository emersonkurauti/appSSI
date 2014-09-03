using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caModulos
    {
        public string nmTabela
        {
            get { return "MODULOS"; }
        }

        public string nmCampoChave
        {
            get { return "cdModulo"; }
        }

        public string cdModulo
        {
            get { return "cdModulo"; }
        }

        public string cdSistema
        {
            get { return "cdSistema"; }
        }

        public string nmModulo
        {
            get { return "nmModulo"; }
        }

        public string taskModulo
        {
            get { return "taskModulo"; }
        }

        #region Campos Calculados

        public string CC_nmSistema
        {
            get { return "CC_nmSistema"; }
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
            strFields = cdModulo + "," + cdSistema + "," + nmModulo + "," + CC_nmSistema + "," + taskModulo;

            strNome = "Código, Código Sistema, Descrição, Sistema, Módulo TASK";

            strVisivel = "0,0,1,1,0";
        }
    }
}
