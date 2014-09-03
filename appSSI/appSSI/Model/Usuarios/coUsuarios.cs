using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace appSSI
{
    public class coUsuarios: csModelBase
    {
        private caUsuarios objCaUsuarios;

        private int _cdUsuario;

        public int cdUsuario
        {
            get { return _cdUsuario; }
            set { _cdUsuario = value; }
        }
        private int _cdEmpresa;

        public int cdEmpresa
        {
            get { return _cdEmpresa; }
            set { _cdEmpresa = value; }
        }
        private string _nmUsuario = "";

        public string nmUsuario
        {
            get { return _nmUsuario; }
            set { _nmUsuario = value; }
        }
        private Int64 _nuCPF;

        public Int64 nuCPF
        {
            get { return _nuCPF; }
            set { _nuCPF = value; }
        }
        private string _deEmail = "";

        public string deEmail
        {
            get { return _deEmail; }
            set { _deEmail = value; }
        }
        private string _deLogin = "";

        public string deLogin
        {
            get { return _deLogin; }
            set { _deLogin = value; }
        }
        private string _deSenha = "";

        public string deSenha
        {
            get { return _deSenha; }
            set { _deSenha = value; }
        }
        private char _flTpUsuario = ' ';

        public char flTpUsuario
        {
            get { return _flTpUsuario; }
            set { _flTpUsuario = value; }
        }
        private char _flAtivo = ' ';

        public char flAtivo
        {
            get { return _flAtivo; }
            set { _flAtivo = value; }
        }

        private string _taskProjeto = "";
        public string taskProjeto
        {
            get { return _taskProjeto; }
            set { _taskProjeto = value; }
        }

        private string _taskUsuario = "";
        public string taskUsuario
        {
            get { return _taskUsuario; }
            set { _taskUsuario = value; }
        }

        #region Campos Calculado

        private string _CC_nmEmpresa = "";

        public string CC_nmEmpresa
        {
            get { return _CC_nmEmpresa; }
            set { _CC_nmEmpresa = value; }
        }

        #endregion

        /// <summary>
        /// Construtor
        /// </summary>
        public coUsuarios()
        {
            objCaUsuarios = new caUsuarios();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaUsuarios.nmCampoChave;
            objBanco.strTabela = objCaUsuarios.nmTabela;
        }

        /// <summary>
        /// Método sobrescrito por conta do campo calculado
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public override bool Select(out DataTable dtDados)
        {
            conEmpresas objconEmpresas = new conEmpresas();
            caEmpresas objcaEmpresas = new caEmpresas();

            if (base.Select(out dtDados))
            {
                dtDados.Columns[objCaUsuarios.CC_nmEmpresa].ReadOnly = false;
                dtDados.Columns[objCaUsuarios.CC_nmEmpresa].MaxLength = 100;

                foreach (DataRow dr in dtDados.Rows)
                {
                    objconEmpresas.objCoEmpresas.LimparAtributos();
                    objconEmpresas.objCoEmpresas.cdEmpresa = Convert.ToInt32(dr[objCaUsuarios.cdEmpresa].ToString());

                    if (objconEmpresas.Select())
                        dr[objCaUsuarios.CC_nmEmpresa] = objconEmpresas.dtDados.Rows[0][objcaEmpresas.nmEmpresa].ToString();
                }
            }
            else
                return false;

            return true;
        }

        /// <summary>
        /// Retorna objeto de usuários com valores preenchidos
        /// </summary>
        /// <param name="dtUsuario"></param>
        /// <returns></returns>
        public coUsuarios RetornaObjUsuario(DataTable dtUsuario)
        {
            Int64 nuCPF;
            coUsuarios objCoUsuarios = new coUsuarios();

            objCoUsuarios.cdUsuario = Convert.ToInt32(dtUsuario.Rows[0][objCaUsuarios.cdUsuario].ToString());
            objCoUsuarios.cdEmpresa = Convert.ToInt32(dtUsuario.Rows[0][objCaUsuarios.cdEmpresa].ToString());
            objCoUsuarios.nmUsuario = dtUsuario.Rows[0][objCaUsuarios.nmUsuario].ToString();
            Int64.TryParse(dtUsuario.Rows[0][objCaUsuarios.nuCPF].ToString(), out nuCPF);
            objCoUsuarios.nuCPF = nuCPF;
            objCoUsuarios.deEmail = dtUsuario.Rows[0][objCaUsuarios.deEmail].ToString();
            objCoUsuarios.deLogin = dtUsuario.Rows[0][objCaUsuarios.deLogin].ToString();
            objCoUsuarios.deSenha = dtUsuario.Rows[0][objCaUsuarios.deSenha].ToString();
            objCoUsuarios.flTpUsuario = Convert.ToChar(dtUsuario.Rows[0][objCaUsuarios.flTpUsuario].ToString());
            objCoUsuarios.flAtivo = Convert.ToChar(dtUsuario.Rows[0][objCaUsuarios.flAtivo].ToString());
            objCoUsuarios.taskProjeto = dtUsuario.Rows[0][objCaUsuarios.taskProjeto].ToString();
            objCoUsuarios.taskUsuario = dtUsuario.Rows[0][objCaUsuarios.taskUsuario].ToString();

            return objCoUsuarios;
        }
    }
}
