using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KuraFrameWork.Componentes_Visuais
{
    public delegate void AoConsultarRegistroEventHandler();

    public partial class ucConsulta : UserControl
    {
        private bool _bCadastrar = true;
        public bool bCadastrar
        {
            get { return _bCadastrar; }
            set
            {
                _bCadastrar = value;
                SetBCadastrar(value);
            }
        }

        private string _Rotulo;
        public string Rotulo
        {
            get { return _Rotulo; }
            set
            {
                _Rotulo = value;
                lblRotulo.Text = value;
            }
        }

        private bool _bCampoObrigatorio;
        public bool CampoObrigatorio
        {
            get { return _bCampoObrigatorio; }
            set { _bCampoObrigatorio = value; }
        }

        private string _strMensagemCampoObrigatorio;
        public string MensagemCampoObrigatorio
        {
            get { return _strMensagemCampoObrigatorio; }
            set { _strMensagemCampoObrigatorio = value; }
        }

        private string _TelaConsulta;
        public string TelaConsulta
        {
            get { return _TelaConsulta; }
            set { _TelaConsulta = value; }
        }

        private int cdAnterior = 0;

        private bool _bMudouCodigo = false;
        public bool bMudouCodigo
        {
            get { return _bMudouCodigo; }
            set { _bMudouCodigo = value; }
        }


        public event AoConsultarRegistroEventHandler AoConsultarRegistro;

        protected virtual void OnAoConsultarRegistro()
        {
            if (AoConsultarRegistro != null)
                AoConsultarRegistro();
        }

        public ucConsulta()
        {
            InitializeComponent();
        }

        public void SetBCadastrar(bool bVisible)
        {
            btnCadastrar.Visible = bVisible;
        }

        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            cdAnterior = 0;
            bMudouCodigo = false;
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btnConsultar_Click(null, null);
        }

        public virtual void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        public virtual void txtCodigo_Leave(object sender, EventArgs e)
        {
            bMudouCodigo = false;

            int iCodigo;

            int.TryParse(txtCodigo.Text, out iCodigo);

            if (cdAnterior != iCodigo)
            {
                cdAnterior = Convert.ToInt32(txtCodigo.Text);
                bMudouCodigo = true;
            }

            OnAoConsultarRegistro();
        }

        private void txtCodigo_DoubleClick(object sender, EventArgs e)
        {
            btnConsultar_Click(null, null);
        }
    }
}
