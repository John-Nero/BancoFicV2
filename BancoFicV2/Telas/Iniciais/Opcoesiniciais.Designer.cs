
namespace BancoFicV2
{
    partial class OpcoesIniciais
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
            this.BtCriarConta = new System.Windows.Forms.Button();
            this.BtLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.BtCriarConta);
            this.groupBox1.Controls.Add(this.BtLogin);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(427, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma opção para avançar";
            // 
            // BtCriarConta
            // 
            this.BtCriarConta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtCriarConta.Location = new System.Drawing.Point(62, 138);
            this.BtCriarConta.Name = "BtCriarConta";
            this.BtCriarConta.Size = new System.Drawing.Size(173, 59);
            this.BtCriarConta.TabIndex = 5;
            this.BtCriarConta.Text = "Criar conta";
            this.BtCriarConta.UseVisualStyleBackColor = true;
            this.BtCriarConta.Click += new System.EventHandler(this.BtCriarConta_Click);
            // 
            // BtLogin
            // 
            this.BtLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtLogin.Location = new System.Drawing.Point(62, 35);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(173, 59);
            this.BtLogin.TabIndex = 4;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1045, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "© BANCO FIC";
            // 
            // OpcoesIniciais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "OpcoesIniciais";
            this.RightToLeftLayout = true;
            this.Text = "Opcoesiniciais";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtCriarConta;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Label label1;
    }
}