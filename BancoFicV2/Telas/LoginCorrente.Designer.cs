
namespace BancoFicV2
{
    partial class LoginCorrente
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
            this.txtNumerodeconta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgenica = new System.Windows.Forms.TextBox();
            this.BTNntrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumerodeconta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAgenica);
            this.groupBox1.Controls.Add(this.BTNntrar);
            this.groupBox1.Location = new System.Drawing.Point(219, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login conta corrente";
            // 
            // txtNumerodeconta
            // 
            this.txtNumerodeconta.Location = new System.Drawing.Point(18, 105);
            this.txtNumerodeconta.Name = "txtNumerodeconta";
            this.txtNumerodeconta.Size = new System.Drawing.Size(338, 23);
            this.txtNumerodeconta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº de conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "agência";
            // 
            // txtAgenica
            // 
            this.txtAgenica.Location = new System.Drawing.Point(18, 41);
            this.txtAgenica.Name = "txtAgenica";
            this.txtAgenica.Size = new System.Drawing.Size(338, 23);
            this.txtAgenica.TabIndex = 1;
            // 
            // BTNntrar
            // 
            this.BTNntrar.Location = new System.Drawing.Point(281, 134);
            this.BTNntrar.Name = "BTNntrar";
            this.BTNntrar.Size = new System.Drawing.Size(75, 23);
            this.BTNntrar.TabIndex = 0;
            this.BTNntrar.Text = "Entrar";
            this.BTNntrar.UseVisualStyleBackColor = true;
            // 
            // LoginCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginCorrente";
            this.Text = "LoginCorrente";
            this.Load += new System.EventHandler(this.LoginCorrente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumerodeconta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgenica;
        private System.Windows.Forms.Button BTNntrar;
    }
}