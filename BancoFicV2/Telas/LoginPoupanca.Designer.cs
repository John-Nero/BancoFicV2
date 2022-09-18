
namespace BancoFicV2
{
    partial class LoginPoupanca
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
            this.GrupoLoginPoupanca = new System.Windows.Forms.GroupBox();
            this.BTEntrar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.LBNumeroPoupanca = new System.Windows.Forms.Label();
            this.LBagenciaPoupanca = new System.Windows.Forms.Label();
            this.GrupoLoginPoupanca.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrupoLoginPoupanca
            // 
            this.GrupoLoginPoupanca.Controls.Add(this.BTEntrar);
            this.GrupoLoginPoupanca.Controls.Add(this.txtNumero);
            this.GrupoLoginPoupanca.Controls.Add(this.txtAgencia);
            this.GrupoLoginPoupanca.Controls.Add(this.LBNumeroPoupanca);
            this.GrupoLoginPoupanca.Controls.Add(this.LBagenciaPoupanca);
            this.GrupoLoginPoupanca.Location = new System.Drawing.Point(219, 144);
            this.GrupoLoginPoupanca.Name = "GrupoLoginPoupanca";
            this.GrupoLoginPoupanca.Size = new System.Drawing.Size(362, 163);
            this.GrupoLoginPoupanca.TabIndex = 1;
            this.GrupoLoginPoupanca.TabStop = false;
            this.GrupoLoginPoupanca.Text = "Login conta poupança";
            // 
            // BTEntrar
            // 
            this.BTEntrar.Location = new System.Drawing.Point(281, 134);
            this.BTEntrar.Name = "BTEntrar";
            this.BTEntrar.Size = new System.Drawing.Size(75, 23);
            this.BTEntrar.TabIndex = 4;
            this.BTEntrar.Text = "Entrar";
            this.BTEntrar.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(10, 98);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(342, 23);
            this.txtNumero.TabIndex = 3;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(6, 44);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(346, 23);
            this.txtAgencia.TabIndex = 2;
            // 
            // LBNumeroPoupanca
            // 
            this.LBNumeroPoupanca.AutoSize = true;
            this.LBNumeroPoupanca.Location = new System.Drawing.Point(10, 80);
            this.LBNumeroPoupanca.Name = "LBNumeroPoupanca";
            this.LBNumeroPoupanca.Size = new System.Drawing.Size(70, 15);
            this.LBNumeroPoupanca.TabIndex = 1;
            this.LBNumeroPoupanca.Text = "Nº de conta";
            // 
            // LBagenciaPoupanca
            // 
            this.LBagenciaPoupanca.AutoSize = true;
            this.LBagenciaPoupanca.Location = new System.Drawing.Point(10, 26);
            this.LBagenciaPoupanca.Name = "LBagenciaPoupanca";
            this.LBagenciaPoupanca.Size = new System.Drawing.Size(48, 15);
            this.LBagenciaPoupanca.TabIndex = 0;
            this.LBagenciaPoupanca.Text = "agência";
            // 
            // LoginPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrupoLoginPoupanca);
            this.Name = "LoginPoupanca";
            this.Text = "LoginPoupanca";
            this.GrupoLoginPoupanca.ResumeLayout(false);
            this.GrupoLoginPoupanca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoLoginPoupanca;
        private System.Windows.Forms.Button BTEntrar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label LBNumeroPoupanca;
        private System.Windows.Forms.Label LBagenciaPoupanca;
    }
}