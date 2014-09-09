using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caAreaTask
    {
        public string nmTabela
        {
            get { return "AREA"; }
        }

        public string nmCampoChave
        {
            get { return "CD_AREA"; }
        }

        public string cd_area
        {
            get { return "CD_AREA"; }
        }

        public string ds_area
        {
            get { return "DS_AREA"; }
        }

        public string bo_ativo
        {
            get { return "BO_ATIVO"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cd_area + "," + ds_area + "," + bo_ativo;

            strNome = "Código, Descrição, Ativo";

            strVisivel = "0,0,0";
        }
    }
}
