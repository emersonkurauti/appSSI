using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appRelatorios
{
    public class coRelatorios: csModelBase
    {
        private caRelatorios objCaRelatorios;

        private int _cdRelatorio;

        public int cdRelatorio
        {
            get { return _cdRelatorio; }
            set { _cdRelatorio = value; }
        }
        private string _deRelatorio = "";

        public string deRelatorio
        {
            get { return _deRelatorio; }
            set { _deRelatorio = value; }
        }
        private string _deProcRelatorio = "";

        public string deProcRelatorio
        {
            get { return _deProcRelatorio; }
            set { _deProcRelatorio = value; }
        }
        private string _nmRelatorio = "";

        public string nmRelatorio
        {
            get { return _nmRelatorio; }
            set { _nmRelatorio = value; }
        }
        private string _deCaminhoRelatorio = "";

        public string deCaminhoRelatorio
        {
            get { return _deCaminhoRelatorio; }
            set { _deCaminhoRelatorio = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coRelatorios()
        {
            objCaRelatorios = new caRelatorios();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaRelatorios.nmCampoChave;
            objBanco.strTabela = objCaRelatorios.nmTabela;
        }
    }
}
