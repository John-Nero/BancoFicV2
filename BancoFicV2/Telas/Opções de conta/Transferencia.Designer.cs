
namespace BancoFicV2
{
    partial class Transferencia
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
            this.BtVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioCorrente = new System.Windows.Forms.RadioButton();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.RadioPoupanca = new System.Windows.Forms.RadioButton();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtTransferir = new System.Windows.Forms.Button();
            this.TxtAgencia = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtVoltar
            // 
            this.BtVoltar.Location = new System.Drawing.Point(12, 12);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtVoltar.TabIndex = 5;
            this.BtVoltar.Text = "Voltar";
            this.BtVoltar.UseVisualStyleBackColor = true;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RadioCorrente);
            this.groupBox1.Controls.Add(this.TxtValor);
            this.groupBox1.Controls.Add(this.RadioPoupanca);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtTransferir);
            this.groupBox1.Controls.Add(this.TxtAgencia);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(286, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizando saque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selecione o tipo de conta do Destinatario";
            // 
            // RadioCorrente
            // 
            this.RadioCorrente.AutoSize = true;
            this.RadioCorrente.Location = new System.Drawing.Point(17, 245);
            this.RadioCorrente.Name = "RadioCorrente";
            this.RadioCorrente.Size = new System.Drawing.Size(106, 19);
            this.RadioCorrente.TabIndex = 7;
            this.RadioCorrente.TabStop = true;
            this.RadioCorrente.Text = "Conta Corrente";
            this.RadioCorrente.UseVisualStyleBackColor = true;
            // 
            // TxtValor
            // 
            this.TxtValor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtValor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtValor.Location = new System.Drawing.Point(6, 159);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(223, 23);
            this.TxtValor.TabIndex = 10;
            // 
            // RadioPoupanca
            // 
            this.RadioPoupanca.AutoSize = true;
            this.RadioPoupanca.Location = new System.Drawing.Point(17, 220);
            this.RadioPoupanca.Name = "RadioPoupanca";
            this.RadioPoupanca.Size = new System.Drawing.Size(113, 19);
            this.RadioPoupanca.TabIndex = 6;
            this.RadioPoupanca.TabStop = true;
            this.RadioPoupanca.Text = "Conta Poupança";
            this.RadioPoupanca.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 141);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(164, 15);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Digite o valor a ser transferido";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtNumero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNumero.Location = new System.Drawing.Point(6, 106);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(223, 23);
            this.TxtNumero.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o numero de conta";
            // 
            // BtTransferir
            // 
            this.BtTransferir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtTransferir.Location = new System.Drawing.Point(84, 285);
            this.BtTransferir.Name = "BtTransferir";
            this.BtTransferir.Size = new System.Drawing.Size(75, 23);
            this.BtTransferir.TabIndex = 0;
            this.BtTransferir.Text = "Transferir";
            this.BtTransferir.UseVisualStyleBackColor = true;
            this.BtTransferir.Click += new System.EventHandler(this.BtTransferir_Click);
            // 
            // TxtAgencia
            // 
            this.TxtAgencia.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtAgencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtAgencia.Location = new System.Drawing.Point(6, 52);
            this.TxtAgencia.Name = "TxtAgencia";
            this.TxtAgencia.Size = new System.Drawing.Size(223, 23);
            this.TxtAgencia.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 34);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(153, 15);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Digite o numero de agência";
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Transferencia";
            this.Text = "Transferencia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtTransferir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioCorrente;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.RadioButton RadioPoupanca;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAgencia;
        private System.Windows.Forms.Label Label4;
    }
}