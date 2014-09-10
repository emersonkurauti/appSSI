namespace appSSI
{
    partial class ucCadImagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnListaImagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvImagens
            // 
            this.lsvImagens.TabIndex = 0;
            this.lsvImagens.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lsvImagens_AfterLabelEdit);
            // 
            // ucCadImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ucCadImagens";
            this.Load += new System.EventHandler(this.ucCadImagens_Load);
            this.pnListaImagem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
