namespace appRelatorios
{
    partial class frmGerenciadorRPT
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
            this.lbRPT = new System.Windows.Forms.ListBox();
            this.gbParam = new System.Windows.Forms.GroupBox();
            this.flpParam = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.gbParam.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRPT
            // 
            this.lbRPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRPT.FormattingEnabled = true;
            this.lbRPT.Location = new System.Drawing.Point(6, 19);
            this.lbRPT.Name = "lbRPT";
            this.lbRPT.Size = new System.Drawing.Size(219, 353);
            this.lbRPT.TabIndex = 0;
            this.lbRPT.SelectedIndexChanged += new System.EventHandler(this.lbRPT_SelectedIndexChanged);
            // 
            // gbParam
            // 
            this.gbParam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParam.Controls.Add(this.flpParam);
            this.gbParam.Location = new System.Drawing.Point(246, 12);
            this.gbParam.Name = "gbParam";
            this.gbParam.Size = new System.Drawing.Size(723, 358);
            this.gbParam.TabIndex = 1;
            this.gbParam.TabStop = false;
            this.gbParam.Text = "Parâmetros";
            // 
            // flpParam
            // 
            this.flpParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpParam.Location = new System.Drawing.Point(3, 16);
            this.flpParam.Name = "flpParam";
            this.flpParam.Size = new System.Drawing.Size(717, 339);
            this.flpParam.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lbRPT);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 384);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatórios";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizar.Location = new System.Drawing.Point(249, 373);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(720, 23);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // frmGerenciadorRPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 406);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbParam);
            this.MinimumSize = new System.Drawing.Size(659, 387);
            this.Name = "frmGerenciadorRPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Relatórios";
            this.Load += new System.EventHandler(this.frmGerenciadorRPT_Load);
            this.gbParam.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRPT;
        private System.Windows.Forms.GroupBox gbParam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpParam;
        private System.Windows.Forms.Button btnVisualizar;
    }
}

