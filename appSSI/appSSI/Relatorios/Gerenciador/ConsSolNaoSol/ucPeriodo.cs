using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucPeriodo : KuraFrameWork.Componentes_Visuais.ucParametroRelatorio
    {
        private string _dtInicial;
        public string dtInicial
        {
            get { return _dtInicial; }
            set { _dtInicial = value; }
        }

        private string _dtFinal;
        public string dtFinal
        {
            get { return _dtFinal; }
            set { _dtFinal = value; }
        }

        public ucPeriodo()
        {
            InitializeComponent();
        }

        private void cbInformar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInformar.Checked)
            {
                dtpInicial.Enabled = true;
                dtpFinal.Enabled = true;
            }
            else
            {
                dtpInicial.Enabled = false;
                dtpFinal.Enabled = false;
            }
        }

        public override string GetParametros()
        {
            if (cbInformar.Checked)
                return strParamtros = "'" + dtpInicial.Value.Date.ToString().Substring(0, 10) + "'" + ',' +
                                      "'" + dtpFinal.Value.Date.ToString().Substring(0, 10) + "'";
            else
                return strParamtros = "null, null";
        }
    }
}
