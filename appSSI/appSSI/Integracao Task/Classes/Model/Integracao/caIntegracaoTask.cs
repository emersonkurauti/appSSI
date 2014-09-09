using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caIntegracaoTask
    {
        public string nmTabela
        {
            get { return "ORDEMSERVICO"; }
        }

        public string nmCampoChave
        {
            get { return "CD_TAREFA"; }
        }

        public string nmCampoChaveFK
        {
            get { return "CD_PROJETO"; }
        }

        public string CD_PROJETO
        {
            get { return "CD_PROJETO"; }
        }

        public string CD_TAREFA
        {
            get { return "CD_TAREFA"; }
        }

        public string CD_AREA
        {
            get { return "CD_AREA"; }
        }

        public string DS_TAREFA
        {
            get { return "DS_TAREFA"; }
        }

        public string DT_CADASTRO
        {
            get { return "DT_CADASTRO"; }
        }

        public string TP_PRIORIDADE
        {
            get { return "TP_PRIORIDADE"; }
        }

        public string TP_STATUS
        {
            get { return "TP_STATUS"; }
        }

        public string TMP_PREVISTO
        {
            get { return "TMP_PREVISTO"; }
        }

        public string TMP_GASTO
        {
            get { return "TMP_GASTO"; }
        }

        public string BO_TRIADO
        {
            get { return "BO_TRIADO"; }
        }

        public string CD_SOLICITANTE
        {
            get { return "CD_SOLICITANTE"; }
        }

        public string BO_TAREFA_AGENDADA
        {
            get { return "BO_TAREFA_AGENDADA"; }
        }

        public string CD_MODULO
        {
            get { return "CD_MODULO"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = "";
            strNome = "";
            strVisivel = "";
        }
    }
}
