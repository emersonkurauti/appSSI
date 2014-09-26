using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucParametroDefSolConsSol : KuraFrameWork.Componentes_Visuais.ucParametroRelatorio
    {
        private int cdSistema = 0;
        private int cdModulo = 0;
        private int cdTela = 0;
        private int cdAcao = 0;

        public ucParametroDefSolConsSol()
        {
            InitializeComponent();
        }

        private void ucSistemasCons_AoConsultarRegistro()
        {
            if (ucSistemasCons.bMudouCodigo)
            {
                ucModulosCons.LimparCampos();
                ucTelasCons.LimparCampos();
                ucAcoesCons.LimparCampos();

                ucModulosCons.cdSistema = Convert.ToInt32(ucSistemasCons.txtCodigo.Text);
                cdSistema = ucModulosCons.cdSistema;
            }
        }

        private void ucModulosCons_AoConsultarRegistro()
        {
            if (ucModulosCons.bMudouCodigo)
            {
                ucTelasCons.LimparCampos();
                ucAcoesCons.LimparCampos();

                ucTelasCons.cdModulo = Convert.ToInt32(ucModulosCons.txtCodigo.Text);
                cdModulo = ucTelasCons.cdModulo; 
            }
        }

        private void ucTelasCons_AoConsultarRegistro()
        {
            if (ucTelasCons.bMudouCodigo)
            {
                ucAcoesCons.LimparCampos();

                ucAcoesCons.cdTela = Convert.ToInt32(ucTelasCons.txtCodigo.Text);
                cdTela = ucAcoesCons.cdTela;
            }
        }

        private void ucAcoesCons_AoConsultarRegistro()
        {
            if (ucAcoesCons.bMudouCodigo)
                cdAcao = Convert.ToInt32(ucAcoesCons.txtCodigo.Text);
        }

        ///compoente terá os parâmetros montados somente para o gerenciador montar a execução

        public override string GetParametros()
        {
            return strParamtros = cdSistema.ToString() + ',' + 
                                  cdModulo.ToString() + ',' + 
                                  cdTela.ToString() + ',' + 
                                  cdAcao.ToString();
        }
    }
}
