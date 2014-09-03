using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace appSSI
{
    public class coSistemasEmpresas: csModelBase
    {
        private caSistemasEmpresas objCaSistemasEmpresas;

        private int _cdEmpresa;
        public int cdEmpresa
        {
            get { return _cdEmpresa; }
            set { _cdEmpresa = value; }
        }

        private int _cdSistema;
        public int cdSistema
        {
            get { return _cdSistema; }
            set { _cdSistema = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coSistemasEmpresas()
        {
            objCaSistemasEmpresas = new caSistemasEmpresas();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.bGerarChave = false;
            objBanco.bControlaConxao = false;
            objBanco.strCampoChave = objCaSistemasEmpresas.nmCampoChave;
            objBanco.strTabela = objCaSistemasEmpresas.nmTabela;
        }
    }
}
