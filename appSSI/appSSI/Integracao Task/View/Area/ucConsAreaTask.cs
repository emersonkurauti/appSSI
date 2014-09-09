using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucConsAreaTask : KuraFrameWork.Componentes_Visuais.ucConsulta
    {
        conAreaTask objConAreaTask;
        caAreaTask objCaAreaTask;

        private int _cd_area;
        public int cd_area
        {
            get { return _cd_area; }
            set { _cd_area = value; }
        }

        public ucConsAreaTask()
        {
            InitializeComponent();
            objConAreaTask = new conAreaTask();
            objCaAreaTask = new caAreaTask();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            if (_cd_area == 0)
            {
                frmConsAcoes form = new frmConsAcoes();
                form.ShowDialog();

                if (form.cdAcao != 0)
                {
                    txtCodigo.Text = form.cdAcao.ToString();
                    txtDescricao.Text = form.deAcao.ToString();
                }
            }
            else
            {
                frmConsAcoesTelas form = new frmConsAcoesTelas();
                form.cdTela = _cd_area;
                form.ShowDialog();

                if (form.cdAcao != 0)
                {
                    txtCodigo.Text = form.cdAcao.ToString();
                    txtDescricao.Text = form.deAcao.ToString();
                }
            }
        }

        public override void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (Convert.ToInt32(txtCodigo.Text) > 0)
                {
                    objConAreaTask.objCoAreaTask.LimparAtributos();
                    objConAreaTask.objCoAreaTask.cd_area = Convert.ToInt32(txtCodigo.Text);
                    objConAreaTask.Select();

                    if (objConAreaTask.dtDados.Rows.Count > 0)
                    {
                        txtCodigo.Text = objConAreaTask.dtDados.Rows[0][objCaAreaTask.cd_area].ToString();
                        txtDescricao.Text = objConAreaTask.dtDados.Rows[0][objCaAreaTask.ds_area].ToString();
                    }
                    else
                    {
                        LimparCampos();
                        MessageBox.Show(csMensagens.msgErroConsultar);
                    }
                }
                else
                {
                    LimparCampos();
                    MessageBox.Show(csMensagens.msgErroValorInvalido);
                }

                base.txtCodigo_Leave(sender, e);
            }
        }

        public void Carregar()
        {
            txtCodigo_Leave(null, null);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
        }
    }
}
