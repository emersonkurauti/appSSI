using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class coIntegracaoTask : csModelBaseTask
    {
        private caIntegracaoTask objCaIntegracaoTask;

        private int _CC_cdUsuario;
        public int CC_cdUsuario
        {
            get { return _CC_cdUsuario; }
            set { _CC_cdUsuario = value; }
        }

        private int _CC_cdSistema;
        public int CC_cdSistema
        {
            get { return _CC_cdSistema; }
            set { _CC_cdSistema = value; }
        }

        private int _CC_cdModelo;
        public int CC_cdModelo
        {
            get { return _CC_cdModelo; }
            set { _CC_cdModelo = value; }
        }

        private int _CC_cdTela;
        public int CC_cdTela
        {
            get { return _CC_cdTela; }
            set { _CC_cdTela = value; }
        }

        private string _CC_descDefeito;
        public string CC_descDefeito
        {
            get { return _CC_descDefeito; }
            set { _CC_descDefeito = value; }
        }

        private string _CD_PROJETO;
        public string CD_PROJETO
        {
            get { return _CD_PROJETO; }
            set { _CD_PROJETO = value; }
        }

        private int _CD_TAREFA;
        public int CD_TAREFA
        {
            get { return _CD_TAREFA; }
            set { _CD_TAREFA = value; }
        }

        private string _CD_AREA;
        public string CD_AREA
        {
            get { return _CD_AREA; }
            set { _CD_AREA = value; }
        }

        private int _CD_NATUREZA;
        public int CD_NATUREZA
        {
            get { return _CD_NATUREZA; }
            set { _CD_NATUREZA = value; }
        }

        private string _DS_TAREFA;
        public string DS_TAREFA
        {
            get { return _DS_TAREFA; }
            set { _DS_TAREFA = value; }
        }

        private string _DT_CADASTRO;
        public string DT_CADASTRO
        {
            get { return _DT_CADASTRO; }
            set { _DT_CADASTRO = value; }
        }

        private char _TP_PRIORIDADE = ' ';
        public char TP_PRIORIDADE
        {
            get { return _TP_PRIORIDADE; }
            set { _TP_PRIORIDADE = value; }
        }

        private char _TP_STATUS = ' ';
        public char TP_STATUS
        {
            get { return _TP_STATUS; }
            set { _TP_STATUS = value; }
        }

        private int _TMP_PREVISTO;
        public int TMP_PREVISTO
        {
            get { return _TMP_PREVISTO; }
            set { _TMP_PREVISTO = value; }
        }

        private int _TMP_GASTO;
        public int TMP_GASTO
        {
            get { return _TMP_GASTO; }
            set { _TMP_GASTO = value; }
        }

        private char _BO_TRIADO = ' ';
        public char BO_TRIADO
        {
            get { return _BO_TRIADO; }
            set { _BO_TRIADO = value; }
        }

        private string _CD_SOLICITANTE;
        public string CD_SOLICITANTE
        {
            get { return _CD_SOLICITANTE; }
            set { _CD_SOLICITANTE = value; }
        }

        private char _BO_TAREFA_AGENDADA = ' ';
        public char BO_TAREFA_AGENDADA
        {
            get { return _BO_TAREFA_AGENDADA; }
            set { _BO_TAREFA_AGENDADA = value; }
        }

        private string _CD_MODULO;
        public string CD_MODULO
        {
            get { return _CD_MODULO; }
            set { _CD_MODULO = value; }
        }

        private string _INF_COMPL;
        public string INF_COMPL
        {
            get { return _INF_COMPL; }
            set { _INF_COMPL = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coIntegracaoTask()
        {
            objCaIntegracaoTask = new caIntegracaoTask();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Preenche as propriedades
        /// </summary>
        public bool PreencheCampo()
        {
            conUsuarios objconUsuarios = new conUsuarios();
            caUsuarios objCaUsuarios = new caUsuarios();
            conSistemas objconSistemas = new conSistemas();
            caSistemas objCaSistemas = new caSistemas();
            conModulos objconModulos = new conModulos();
            caModulos objCaModulos = new caModulos();

            objconUsuarios.objCoUsuarios.cdUsuario = _CC_cdUsuario;
            if (!objconUsuarios.Select())
                return false;

            objconSistemas.objCoSistemas.cdSistema = _CC_cdSistema;
            if (!objconSistemas.Select())
                return false;

            objconModulos.objCoModulos.cdModulo = _CC_cdModelo;
            objconModulos.objCoModulos.cdSistema = _CC_cdSistema;
            if (!objconModulos.Select())
                return false;

            if (objconUsuarios.objCoUsuarios.flTpUsuario == 'C')
                _CD_PROJETO = objconSistemas.dtDados.Rows[0][objCaSistemas.taskProjeto].ToString();
            else
                _CD_PROJETO = objconUsuarios.dtDados.Rows[0][objCaUsuarios.taskProjeto].ToString();

            _CD_AREA = objconSistemas.dtDados.Rows[0][objCaSistemas.taskArea].ToString();
            _CD_MODULO = objconModulos.dtDados.Rows[0][objCaModulos.taskModulo].ToString();
            _CD_SOLICITANTE = objconUsuarios.dtDados.Rows[0][objCaUsuarios.taskUsuario].ToString();
            _CD_NATUREZA = 3;
            _TMP_PREVISTO = 0;
            _TMP_GASTO = 0;
            _DT_CADASTRO = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            _TP_PRIORIDADE = '3';
            _TP_STATUS = 'A';
            _BO_TRIADO = 'N';
            _BO_TAREFA_AGENDADA = 'N';

            _INF_COMPL = _CC_descDefeito;

            if (_CC_descDefeito.Length > 100)
                _DS_TAREFA = _CC_descDefeito.Substring(1, 100);
            else
                _DS_TAREFA = _CC_descDefeito;

            return true;
        }

        /// <summary>
        /// Sobrescrito para retornar a chave
        /// </summary>
        /// <returns></returns>
        public override bool Inserir()
        {
            if (!PreencheCampo())
                return false;

            objBanco.strValorCampoChaveFK = _CD_PROJETO;
            if (base.Inserir())
            {
                _CD_TAREFA = objBanco.cdChave;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaIntegracaoTask.nmCampoChave;
            objBanco.strTabela = objCaIntegracaoTask.nmTabela;
            objBanco.strCampoChaveFK = objCaIntegracaoTask.nmCampoChaveFK;
        }
    }
}
