using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appRelatorios
{
    public class coTipoParametro: csModelBase
    {
        private caTipoParametro objCaTipoParametro;

        private int _cdTipoParametro;

        public int cdTipoParametro
        {
            get { return _cdTipoParametro; }
            set { _cdTipoParametro = value; }
        }
        private string _deTipoParametro = "";

        public string deTipoParametro
        {
            get { return _deTipoParametro; }
            set { _deTipoParametro = value; }
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
