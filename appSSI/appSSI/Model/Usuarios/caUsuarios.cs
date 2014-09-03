using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caUsuarios
    {
        public string nmTabela
        {
            get { return "USUARIOS"; }
        }

        public string nmCampoChave
        {
            get { return "cdUsuario"; }
        }

        public string cdUsuario
        {
            get { return "cdUsuario"; }
        }

        public string cdEmpresa
        {
            get { return "cdEmpresa"; }
        }

        public string nmUsuario
        {
            get { return "nmUsuario"; }
        }

        public string nuCPF
        {
            get { return "nuCPF"; }
        }

        public string deEmail
        {
            get { return "deEmail"; }
        }

        public string deLogin
        {
            get { return "deLogin"; }
        }

        public string deSenha
        {
            get { return "deSenha"; }
        }

        public string flTpUsuario
        {
            get { return "flTpUsuario"; }
        }

        public string flAtivo
        {
            get { return "flAtivo"; }
        }

        public string taskProjeto
        {
            get { return "taskProjeto"; }
        }

        public string taskUsuario
        {
            get { return "taskUsuario"; }
        }

        #region Campos Calculados

        public string CC_nmEmpresa
        {
            get { return "CC_nmEmpresa"; }
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
            strFields = cdUsuario + "," +
                nmUsuario + "," +
                nuCPF + "," +
                cdEmpresa + "," +
                flAtivo + "," +
                flTpUsuario + "," +
                deEmail + "," +
                deLogin + "," +
                deSenha + "," +
                CC_nmEmpresa + "," +
                taskProjeto;

            strNome = "Código, Nome, CPF, Empresa, Ativo, Tipo, E-mail, Login, Senha, Nome Empresa, Projeto TASK, Usuário TASK";

            strVisivel = "0,1,1,0,1,1,0,0,0,1,0,0";
        }
    }
}
