using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appRelatorios
{
    public class coTipoParametro: csModelBase
    {
        private caTipoParametro objCaTipoParametro;

        private int _cdTpParametro;

        public int cdTpParametro
        {
            get { return _cdTpParametro; }
            set { _cdTpParametro = value; }
        }
        private string _deTpParametro = "";

        public string deTpParametro
        {
            get { return _deTpParametro; }
            set { _deTpParametro = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coTipoParametro()
        {
            objCaTipoParametro = new caTipoParametro();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaTipoParametro.nmCampoChave;
            objBanco.strTabela = objCaTipoParametro.nmTabela;
        }
    }
}
