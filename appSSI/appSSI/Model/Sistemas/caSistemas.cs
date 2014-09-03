using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caSistemas
    {
        public string nmTabela
        {
            get { return "SISTEMAS"; }
        }

        public string nmCampoChave
        {
            get { return "cdSistema"; }
        }

        public string cdSistema
        {
            get { return "cdSistema"; }
        }

        public string nmSistema
        {
            get { return "nmSistema"; }
        }

        public string taskProjeto
        {
            get { return "taskProjeto"; }
        }

        public string taskArea
        {
            get { return "taskArea"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdSistema + "," + nmSistema + "," + taskProjeto + "," + taskArea;

            strNome = "Código, Nome, Projeto TASK, Área TASK";

            strVisivel = "0,1,0,0";
        }
    }
}
