using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caSistemasEmpresas
    {
        public string nmTabela
        {
            get { return "SISTEMAS_EMPRESAS"; }
        }

        public string nmCampoChave
        {
            get { return "cdEmpresa"; }
        }

        public string cdSistema
        {
            get { return "cdSistema"; }
        }

        public string cdEmpresa
        {
            get { return "cdEmpresa"; }
        }

        /// <summary>
        /// Retorna os fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdSistema + "," + cdEmpresa;

            strNome = "cdSistema, cdEmpresa";

            strVisivel = "0,0";
        }
    }
}
