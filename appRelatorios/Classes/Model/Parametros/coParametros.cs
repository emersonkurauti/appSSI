﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appRelatorios
{
    public class coParametros: csModelBase
    {
        private caParametros objCaParametros;

        private int _cdParamRelatorio;

        public int cdParamRelatorio
        {
            get { return _cdParamRelatorio; }
            set { _cdParamRelatorio = value; }
        }
        private int _cdTpParametro;

        public int cdTpParametro
        {
            get { return _cdTpParametro; }
            set { _cdTpParametro = value; }
        }
        private int _cdRelatorio;

        public int cdRelatorio
        {
            get { return _cdRelatorio; }
            set { _cdRelatorio = value; }
        }
        private string _nmParamRelatorio = "";

        public string nmParamRelatorio
        {
            get { return _nmParamRelatorio; }
            set { _nmParamRelatorio = value; }
        }
        private string _deSqlParamRelatorio = "";

        public string deSqlParamRelatorio
        {
            get { return _deSqlParamRelatorio; }
            set { _deSqlParamRelatorio = value; }
        }

        private string _deComponente = "";

        public string deComponente
        {
            get { return _deComponente; }
            set { _deComponente = value; }
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
            objBanco.strCampoChave = objCaParametros.nmCampoChave;
            objBanco.strTabela = objCaParametros.nmTabela;
        }
    }
}
