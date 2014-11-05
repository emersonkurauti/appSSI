using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Banco;
using System.Collections;
using appRelatorios;

namespace appSSI
{
    public partial class frmMenu : KuraFrameWork.Formularios.ucMenuBasico
    {
        private ArrayList alIntSeqTelas = new ArrayList();
        private ArrayList alTelas = new ArrayList();

        private coUsuarios _objUsuario;
        public coUsuarios objUsuario
        {
            get { return _objUsuario; }
            set { _objUsuario = value; }
        }

        /// <summary>
        /// Construtor do menu
        /// </summary>
        /// <param name="objUsuario"></param>
        public frmMenu(coUsuarios objUsuario)
        {
            InitializeComponent();
            _objUsuario = objUsuario;

            csBanco objBanco = csBanco.Instance;
            objBanco.cdUsuario = _objUsuario.cdUsuario;
        }

        /// <summary>
        /// Carrega items de menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_Load(object sender, EventArgs e)
        {
            ItemMenuStrip();
            ItemToolStrip();
        }

        /// <summary>
        /// Adiciona o nome do formulário na lista para pesquisa rápida
        /// </summary>
        /// <param name="nmTipoForm"></param>
        public void AddListTela(string nmTipoForm)
        {
            Type tipo;
            System.Windows.Forms.Form form;

            tipo = Type.GetType(nmTipoForm);

            form = (System.Windows.Forms.Form)Activator.CreateInstance(tipo);
            alTelas.Add(form.Text);
        }

        /// <summary>
        /// Adiciona items de menu
        /// </summary>
        public override void ItemMenuStrip()
        {
            AddListTela("appSSI.frmCadEmpresas");
            AddListTela("appSSI.frmCadUsuarios");
            AddListTela("appSSI.frmCadSistemas");
            AddListTela("appSSI.frmCadModulos");
            AddListTela("appSSI.frmCadTelas");
            AddListTela("appSSI.frmCadAcoes");
            AddListTela("appSSI.frmCadDefeitos");
            AddListTela("appSSI.frmCadSolucoes");
            AddListTela("appRelatorios.frmGerenciadorRPT,appRelatorios");

            ToolStripMenuItem menuCadastros = RetornarItemMenuCriado(menuStrip, "&Cadastros", null, null, "btnCadastros");
            CriarSubItemMenu(menuCadastros, "&Empresas...", null, ItemMenu_onClick, "appSSI.frmCadEmpresas");
            CriarSubItemMenu(menuCadastros, "&Usuários...", null, ItemMenu_onClick, "appSSI.frmCadUsuarios");
            CriarSubItemMenu(menuCadastros, "&Sistemas...", null, ItemMenu_onClick, "appSSI.frmCadSistemas");
            CriarSubItemMenu(menuCadastros, "&Modulos...", null, ItemMenu_onClick, "appSSI.frmCadModulos");
            CriarSubItemMenu(menuCadastros, "&Telas...", null, ItemMenu_onClick, "appSSI.frmCadTelas");
            CriarSubItemMenu(menuCadastros, "&Ações...", null, ItemMenu_onClick, "appSSI.frmCadAcoes");
            CriarSubItemMenu(menuCadastros, "&Defeitos...", null, ItemMenu_onClick, "appSSI.frmCadDefeitos");
            CriarSubItemMenu(menuCadastros, "&Soluções...", null, ItemMenu_onClick, "appSSI.frmCadSolucoes");

            if (_objUsuario.flTpUsuario == csConstantes.cGestor)
            {
                ToolStripMenuItem menuRelatorios = RetornarItemMenuCriado(menuStrip, "&Gerenciador de Relatórios", null, ItemMenu_onClick, "appRelatorios.frmGerenciadorRPT,appRelatorios");
            }

            AddItemMenu(menuStrip, "&Sair", null, btnSair_onClick, "btnSair");
        }

        /// <summary>
        /// Adiciona botões com imagens
        /// </summary>
        public override void ItemToolStrip()
        {
            AddToolStripItem(tsMenu, Properties.Resources.Fechar, btnSair_onClick, "btnSair");
        }

        /// <summary>
        /// Método para abrir as as telas do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ItemMenu_onClick(object sender, EventArgs e)
        {
            Type tipo = Type.GetType(((ToolStripMenuItem)sender).Name);

            if (!VerificaTelaAberta(((ToolStripMenuItem)sender).Name))
            {
                System.Windows.Forms.Form form = (System.Windows.Forms.Form)Activator.CreateInstance(tipo);

                for (int i = 0; i < menuTelas.Items.Count; i++)
                    menuTelas.Items[i].BackColor = Color.White;

                AtualizaIndiceTelas();
                alIntSeqTelas.Add(0);

                ToolStripMenuItem ItemMenuTela = RetornarItemMenuCriado(menuTelas, form.Text, null, ItemMenuTela_onClick, ((ToolStripMenuItem)sender).Name);
                ItemMenuTela.BackColor = Color.LightGray;

                form.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Verifica se a tela está aberta
        /// </summary>
        /// <param name="nmTela"></param>
        /// <returns></returns>
        public bool VerificaTelaAberta(string nmTela)
        {
            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if (menuTelas.Items[i].Name.Equals(nmTela))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Atualiza os indices da sequência de abertura das telas
        /// </summary>
        /// <param name="bAdd"></param>
        private void AtualizaIndiceTelas(bool bAdd = true)
        {
            if (bAdd)
                for (int i = 0; i < alIntSeqTelas.Count; i++)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) + 1).ToString();
            else
                for (int i = 0; i < alIntSeqTelas.Count; i++)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) - 1).ToString();
        }

        /// <summary>
        /// Remaneja os indices para que mantenha a sequênci de abertura das telas atualizado
        /// </summary>
        /// <param name="nmTela"></param>
        public void RemanejaIndiceTela(string nmTela)
        {
            int IndAnterior = 0, pos0 = 0;

            for (int i = 0; i < menuTelas.Items.Count; i++)
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("appSSI.", "").Equals(nmTela))
                {
                    IndAnterior = Convert.ToInt32(alIntSeqTelas[i].ToString());
                    pos0 = i;
                }

            for (int i = 0; i < alIntSeqTelas.Count; i++)
                if(Convert.ToInt32(alIntSeqTelas[i].ToString()) < IndAnterior)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) + 1).ToString();

            alIntSeqTelas[pos0] = 0;
        }

        /// <summary>
        /// Evento de fechar um MdiChild
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            AtualizaIndiceTelas(false);

            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("appSSI.", "").Equals(((Form)sender).Name))
                {
                    menuTelas.Items.RemoveAt(i);
                    alIntSeqTelas.RemoveAt(i);
                }
            }

            for (int i = 0; i < alIntSeqTelas.Count; i++)
                if (Convert.ToInt32(alIntSeqTelas[i].ToString()) == 0)
                    menuTelas.Items[i].BackColor = Color.LightGray;
        }

        /// <summary>
        /// Evento disparado ao clicar em um menu de tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ItemMenuTela_onClick(object sender, EventArgs e)
        {
            Type tipo = Type.GetType(((ToolStripMenuItem)sender).Name);

            Form[] formMDI = MdiChildren;

            foreach (Form frm in formMDI)
                if (frm.Name.Equals(tipo.Name))
                    frm.Activate();

            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("appSSI.", "").Equals(tipo.Name))
                    menuTelas.Items[i].BackColor = Color.LightGray;
                else
                    menuTelas.Items[i].BackColor = Color.White;
            }

            RemanejaIndiceTela(tipo.Name);
        }
    }
}
