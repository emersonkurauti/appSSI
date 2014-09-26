namespace appSSI
{
    partial class ucPeriodo
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
            this.gbPeriodo = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.cbInformar = new System.Windows.Forms.CheckBox();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.gbPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPeriodo.Controls.Add(this.lblA);
            this.gbPeriodo.Controls.Add(this.dtpFinal);
            this.gbPeriodo.Controls.Add(this.cbInformar);
            this.gbPeriodo.Controls.Add(this.dtpInicial);
            this.gbPeriodo.Location = new System.Drawing.Point(0, 0);
            this.gbPeriodo.Name = "gbPeriodo";
            this.gbPeriodo.Size = new System.Drawing.Size(232, 68);
            this.gbPeriodo.TabIndex = 0;
            this.gbPeriodo.TabStop = false;
            this.gbPeriodo.Text = "Período";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(110, 48);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "à";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(129, 42);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(97, 20);
            this.dtpFinal.TabIndex = 2;
            // 
            // cbInformar
            // 
            this.cbInformar.AutoSize = true;
            this.cbInformar.Checked = true;
            this.cbInformar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInformar.Location = new System.Drawing.Point(6, 19);
            this.cbInformar.Name = "cbInformar";
            this.cbInformar.Size = new System.Drawing.Size(73, 17);
            this.cbInformar.TabIndex = 1;
            this.cbInformar.Text = "Informado";
            this.cbInformar.UseVisualStyleBackColor = true;
            this.cbInformar.CheckedChanged += new System.EventHandler(this.cbInformar_CheckedChanged);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(6, 42);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(97, 20);
            this.dtpInicial.TabIndex = 0;
            // 
            // ucPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbPeriodo);
            this.Name = "ucPeriodo";
            this.Size = new System.Drawing.Size(436, 68);
            this.gbPeriodo.ResumeLayout(false);
            this.gbPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbPeriodo;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.CheckBox cbInformar;
    }
}
