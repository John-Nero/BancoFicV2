
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
            this.criarCorrente = new System.Windows.Forms.Button();
            this.criarPoupanca = new System.Windows.Forms.Button();
            this.loginCorrente = new System.Windows.Forms.Button();
            this.loginPoupanca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.criarCorrente);
            this.groupBox1.Controls.Add(this.criarPoupanca);
            this.groupBox1.Controls.Add(this.loginCorrente);
            this.groupBox1.Controls.Add(this.loginPoupanca);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(427, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma opção para avançar";
            // 
            // criarCorrente
            // 
            this.criarCorrente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.criarCorrente.Location = new System.Drawing.Point(72, 167);
            this.criarCorrente.Name = "criarCorrente";
            this.criarCorrente.Size = new System.Drawing.Size(148, 23);
            this.criarCorrente.TabIndex = 3;
            this.criarCorrente.Text = "Criar conta corrente    ";
            this.criarCorrente.UseVisualStyleBackColor = true;
            this.criarCorrente.Click += new System.EventHandler(this.CriarCorrente_Click);
            // 
            // criarPoupanca
            // 
            this.criarPoupanca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.criarPoupanca.Location = new System.Drawing.Point(72, 138);
            this.criarPoupanca.Name = "criarPoupanca";
            this.criarPoupanca.Size = new System.Drawing.Size(148, 23);
            this.criarPoupanca.TabIndex = 2;
            this.criarPoupanca.Text = "Criar conta poupança";
            this.criarPoupanca.UseVisualStyleBackColor = true;
            this.criarPoupanca.Click += new System.EventHandler(this.CriarPoupanca_Click);
            // 
            // loginCorrente
            // 
            this.loginCorrente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.loginCorrente.Location = new System.Drawing.Point(72, 109);
            this.loginCorrente.Name = "loginCorrente";
            this.loginCorrente.Size = new System.Drawing.Size(148, 23);
            this.loginCorrente.TabIndex = 1;
            this.loginCorrente.Text = "Login Conta corrente";
            this.loginCorrente.UseVisualStyleBackColor = true;
            this.loginCorrente.Click += new System.EventHandler(this.LoginCorrente_Click);
            // 
            // loginPoupanca
            // 
            this.loginPoupanca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.loginPoupanca.Location = new System.Drawing.Point(72, 80);
            this.loginPoupanca.Name = "loginPoupanca";
            this.loginPoupanca.Size = new System.Drawing.Size(148, 23);
            this.loginPoupanca.TabIndex = 0;
            this.loginPoupanca.Text = "Login conta poupança";
            this.loginPoupanca.UseVisualStyleBackColor = true;
            this.loginPoupanca.Click += new System.EventHandler(this.LoginPoupanca_Click);
            // 
            // Opcoesiniciais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.Controls.Add(this.groupBox1);
            this.Name = "Opcoesiniciais";
            this.RightToLeftLayout = true;
            this.Text = "Opcoesiniciais";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button criarCorrente;
        private System.Windows.Forms.Button criarPoupanca;
        private System.Windows.Forms.Button loginCorrente;
        private System.Windows.Forms.Button loginPoupanca;
    }
}