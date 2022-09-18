
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
            this.groupBox1.Controls.Add(this.criarCorrente);
            this.groupBox1.Controls.Add(this.criarPoupanca);
            this.groupBox1.Controls.Add(this.loginCorrente);
            this.groupBox1.Controls.Add(this.loginPoupanca);
            this.groupBox1.Location = new System.Drawing.Point(288, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // criarCorrente
            // 
            this.criarCorrente.Location = new System.Drawing.Point(33, 125);
            this.criarCorrente.Name = "criarCorrente";
            this.criarCorrente.Size = new System.Drawing.Size(148, 23);
            this.criarCorrente.TabIndex = 3;
            this.criarCorrente.Text = "Criar conta corrente    ";
            this.criarCorrente.UseVisualStyleBackColor = true;
            this.criarCorrente.Click += new System.EventHandler(this.criarCorrente_Click);
            // 
            // criarPoupanca
            // 
            this.criarPoupanca.Location = new System.Drawing.Point(33, 96);
            this.criarPoupanca.Name = "criarPoupanca";
            this.criarPoupanca.Size = new System.Drawing.Size(148, 23);
            this.criarPoupanca.TabIndex = 2;
            this.criarPoupanca.Text = "Criar conta poupança";
            this.criarPoupanca.UseVisualStyleBackColor = true;
            this.criarPoupanca.Click += new System.EventHandler(this.criarPoupanca_Click);
            // 
            // loginCorrente
            // 
            this.loginCorrente.Location = new System.Drawing.Point(33, 67);
            this.loginCorrente.Name = "loginCorrente";
            this.loginCorrente.Size = new System.Drawing.Size(148, 23);
            this.loginCorrente.TabIndex = 1;
            this.loginCorrente.Text = "Login Conta corrente";
            this.loginCorrente.UseVisualStyleBackColor = true;
            this.loginCorrente.Click += new System.EventHandler(this.loginCorrente_Click);
            // 
            // loginPoupanca
            // 
            this.loginPoupanca.Location = new System.Drawing.Point(33, 38);
            this.loginPoupanca.Name = "loginPoupanca";
            this.loginPoupanca.Size = new System.Drawing.Size(148, 23);
            this.loginPoupanca.TabIndex = 0;
            this.loginPoupanca.Text = "Login conta poupança";
            this.loginPoupanca.UseVisualStyleBackColor = true;
            this.loginPoupanca.Click += new System.EventHandler(this.loginPoupanca_Click);
            // 
            // Opcoesiniciais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Opcoesiniciais";
            this.Text = "Opcoesiniciais";
            this.Load += new System.EventHandler(this.Opcoesiniciais_Load);
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