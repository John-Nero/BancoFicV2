
namespace BancoFicV2
{
    partial class Opcoesiniciais
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtCriarCorrente = new System.Windows.Forms.Button();
            this.BtCriarPoupanca = new System.Windows.Forms.Button();
            this.BtLoginCorrente = new System.Windows.Forms.Button();
            this.BtLoginPoupanca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.BtCriarCorrente);
            this.groupBox1.Controls.Add(this.BtCriarPoupanca);
            this.groupBox1.Controls.Add(this.BtLoginCorrente);
            this.groupBox1.Controls.Add(this.BtLoginPoupanca);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(427, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma opção para avançar";
            // 
            // BtCriarCorrente
            // 
            this.BtCriarCorrente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtCriarCorrente.Location = new System.Drawing.Point(72, 167);
            this.BtCriarCorrente.Name = "BtCriarCorrente";
            this.BtCriarCorrente.Size = new System.Drawing.Size(148, 23);
            this.BtCriarCorrente.TabIndex = 3;
            this.BtCriarCorrente.Text = "Criar conta corrente    ";
            this.BtCriarCorrente.UseVisualStyleBackColor = true;
            this.BtCriarCorrente.Click += new System.EventHandler(this.CriarCorrente_Click);
            // 
            // BtCriarPoupanca
            // 
            this.BtCriarPoupanca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtCriarPoupanca.Location = new System.Drawing.Point(72, 138);
            this.BtCriarPoupanca.Name = "BtCriarPoupanca";
            this.BtCriarPoupanca.Size = new System.Drawing.Size(148, 23);
            this.BtCriarPoupanca.TabIndex = 2;
            this.BtCriarPoupanca.Text = "Criar conta poupança";
            this.BtCriarPoupanca.UseVisualStyleBackColor = true;
            this.BtCriarPoupanca.Click += new System.EventHandler(this.CriarPoupanca_Click);
            // 
            // BtLoginCorrente
            // 
            this.BtLoginCorrente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtLoginCorrente.Location = new System.Drawing.Point(72, 109);
            this.BtLoginCorrente.Name = "BtLoginCorrente";
            this.BtLoginCorrente.Size = new System.Drawing.Size(148, 23);
            this.BtLoginCorrente.TabIndex = 1;
            this.BtLoginCorrente.Text = "Login conta corrente";
            this.BtLoginCorrente.UseVisualStyleBackColor = true;
            this.BtLoginCorrente.Click += new System.EventHandler(this.LoginCorrente_Click);
            // 
            // BtLoginPoupanca
            // 
            this.BtLoginPoupanca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtLoginPoupanca.Location = new System.Drawing.Point(72, 80);
            this.BtLoginPoupanca.Name = "BtLoginPoupanca";
            this.BtLoginPoupanca.Size = new System.Drawing.Size(148, 23);
            this.BtLoginPoupanca.TabIndex = 0;
            this.BtLoginPoupanca.Text = "Login conta poupança";
            this.BtLoginPoupanca.UseVisualStyleBackColor = true;
            this.BtLoginPoupanca.Click += new System.EventHandler(this.LoginPoupanca_Click);
            // 
            // Opcoesiniciais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.Controls.Add(this.groupBox1);
            this.Name = "Opcoesiniciais";
            this.RightToLeftLayout = true;
            this.Text = "Opcoesiniciais";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtCriarCorrente;
        private System.Windows.Forms.Button BtCriarPoupanca;
        private System.Windows.Forms.Button BtLoginCorrente;
        private System.Windows.Forms.Button BtLoginPoupanca;
    }
}