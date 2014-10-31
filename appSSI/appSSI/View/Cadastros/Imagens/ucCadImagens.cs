using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace appSSI
{
    public partial class ucCadImagens : KuraFrameWork.Componentes_Visuais.ucImagens
    {
        private DataTable _dtImagens;
        public DataTable dtImagens
        {
            get { return _dtImagens; }
            set { _dtImagens = value; }
        }

        private int _cdSolucao;
        public int cdSolucao
        {
            get { return _cdSolucao; }
            set { _cdSolucao = value; }
        }

        private int _cdDefeito;
        public int cdDefeito
        {
            get { return _cdDefeito; }
            set { _cdDefeito = value; }
        }

        private bool _flDefeito;
        public bool flDefeito
        {
            get { return _flDefeito; }
            set { _flDefeito = value; }
        }

        private conImagens objConImagens;
        private caImagens objCaImagens;
        
        public ucCadImagens()
        {
            InitializeComponent();
            if (flDefeito)
            {
                objConImagens = new conImagens(csConstantes.cDefeito);
                _dtImagens = objConImagens.objCoImagensDefeitos.RetornaEstruturaDT();
            }
            else
            {
                objConImagens = new conImagens(csConstantes.cSolucao);
                _dtImagens = objConImagens.objCoImagensSolucoes.RetornaEstruturaDT();
            }
            objCaImagens = new caImagens();
        }

        public void CarregarImagens()
        {
            btnLimparLista_Click(null, null);

            if (flDefeito)
            {
                objConImagens.tpImagem = csConstantes.cDefeito;
                objConImagens.objCoImagensDefeitos.LimparAtributos();
                objConImagens.objCoImagensDefeitos.cdDefeito = _cdDefeito;
            }
            else
            {
                objConImagens.tpImagem = csConstantes.cSolucao;
                objConImagens.objCoImagensSolucoes.LimparAtributos();
                objConImagens.objCoImagensSolucoes.cdSolucao = _cdSolucao;
            }

            objConImagens.Select();

            if (objConImagens.dtDados != null)
            {
                _dtImagens = objConImagens.dtDados.Clone();
                _dtImagens = objConImagens.dtDados.Copy();
            }
        
            for (int i = 0; i < _dtImagens.Rows.Count; i++)
                if (flDefeito)
                    AddImagem(Image.FromFile(appSSI.Properties.Settings.Default.sCaminhoDefeitos + _dtImagens.Rows[i][objCaImagens.blImagem].ToString()),
                        _dtImagens.Rows[i][objCaImagens.deImagem].ToString());
                else
                    AddImagem(Image.FromFile(appSSI.Properties.Settings.Default.sCaminhoSolucoes + _dtImagens.Rows[i][objCaImagens.blImagem].ToString()),
                        _dtImagens.Rows[i][objCaImagens.deImagem].ToString());
        }

        public override void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgImagem.ShowDialog() == DialogResult.OK)
                {
                    if (_dtImagens.Rows.Count == 0)
                        if (flDefeito)
                            _dtImagens = objConImagens.objCoImagensDefeitos.RetornaEstruturaDT();

                    for (int i = 0; i < dlgImagem.SafeFileNames.Length; i++)
                    {
                        string strPath = Path.GetDirectoryName(dlgImagem.FileName) + "\\";
                        AddImagem(Image.FromFile(strPath + dlgImagem.SafeFileNames[i]));

                        DataRow dr = _dtImagens.NewRow();

                        if (flDefeito)
                            dr[objCaImagens.cdDefeito] = _cdDefeito;
                        else
                            dr[objCaImagens.cdSolucao] = _cdSolucao;

                        dr[objCaImagens.cdImagem] = 0;
                        dr[objCaImagens.deImagem] = (imgListaImagens.Images.Count - 1).ToString();
                        dr[objCaImagens.deCaminhoImagem] = strPath;
                        dr[objCaImagens.blImagem] = dlgImagem.SafeFileNames[i].ToString();

                        _dtImagens.Rows.Add(dr);
                    }
                }                
            }catch
            {
                
            }
        }

        private void lsvImagens_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            ListView.SelectedIndexCollection indexes =
            this.lsvImagens.SelectedIndices;

            foreach (int index in indexes)
            {
                _dtImagens.Rows[index][objCaImagens.deImagem] = e.Label.ToString();
            }
        }

        public override void btnLimparLista_Click(object sender, EventArgs e)
        {
            _dtImagens.Rows.Clear();
            base.btnLimparLista_Click(sender, e);
        }

        private void ucCadImagens_Load(object sender, EventArgs e)
        {
            /*if (flDefeito)
                _dtImagens = objConImagens.objCoImagensDefeitos.RetornaEstruturaDT();
            else
                _dtImagens = objConImagens.objCoImagens.RetornaEstruturaDT();*/
        }

        public override void btnRemoverImagem_Click(object sender, EventArgs e)
        {
            int diferentca = 0;
            for (int i = 0; i < lsvImagens.Items.Count; i++)
            {
                if (lsvImagens.Items[i].Checked)
                {
                    _dtImagens.Rows.RemoveAt(i - diferentca++);
                }
            }
            base.btnRemoverImagem_Click(sender, e);
        }
    }
}
