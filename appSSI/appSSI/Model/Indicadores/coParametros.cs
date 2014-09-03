using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class coParametros : csModelBase
    {
        private caParametros objCaParametros;

        private int _cdParametro;
        public int cdParametro
        {
            get { return _cdParametro; }
            set { _cdParametro = value; }
        }

        private int _cdIndicador;
        public int cdIndicador
        {
            get { return _cdIndicador; }
            set { _cdIndicador = value; }
        }

        private string _nmParametro = "";
        public string nmParametro
        {
          get { return _nmParametro; }
          set { _nmParametro = value; }
        }

        private string _vlParametro = "";
        public string vlParametro
        {
            get { return _vlParametro; }
            set { _vlParametro = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coParametros()
        {
            objCaParametros = new caParametros();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.bControlaConxao = false;
            objBanco.strCampoChave = objCaParametros.nmCampoChave;
            objBanco.strTabela = objCaParametros.nmTabela;
        }
    }
}
