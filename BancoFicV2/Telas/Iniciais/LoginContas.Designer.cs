
namespace BancoFicV2
{
    partial class LoginContas
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
            this.label3 = new System.Windows.Forms.Label();
            this.RadioCorrente = new System.Windows.Forms.RadioButton();
            this.RadioPoupanca = new System.Windows.Forms.RadioButton();
            this.NumAgencia = new System.Windows.Forms.NumericUpDown();
            this.TxtNumeroDeConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtEntrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAgencia)).BeginInit();
            this.SuspendLayout();
            // 
            // BtVoltar
            // 
            this.BtVoltar.Location = new System.Drawing.Point(12, 12);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtVoltar.TabIndex = 6;
            this.BtVoltar.Text = "Voltar";
            this.BtVoltar.UseVisualStyleBackColor = true;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RadioCorrente);
            this.groupBox1.Controls.Add(this.RadioPoupanca);
            this.groupBox1.Controls.Add(this.NumAgencia);
            this.groupBox1.Controls.Add(this.TxtNumeroDeConta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtEntrar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(426, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 267);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preencha os dados abaixo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selecione o tipo de conta que deseja logar";
            // 
            // RadioCorrente
            // 
            this.RadioCorrente.AutoSize = true;
            this.RadioCorrente.Location = new System.Drawing.Point(29, 198);
            this.RadioCorrente.Name = "RadioCorrente";
            this.RadioCorrente.Size = new System.Drawing.Size(104, 19);
            this.RadioCorrente.TabIndex = 13;
            this.RadioCorrente.TabStop = true;
            this.RadioCorrente.Text = "Conta corrente";
            this.RadioCorrente.UseVisualStyleBackColor = true;
            // 
            // RadioPoupanca
            // 
            this.RadioPoupanca.AutoSize = true;
            this.RadioPoupanca.Location = new System.Drawing.Point(29, 173);
            this.RadioPoupanca.Name = "RadioPoupanca";
            this.RadioPoupanca.Size = new System.Drawing.Size(113, 19);
            this.RadioPoupanca.TabIndex = 12;
            this.RadioPoupanca.TabStop = true;
            this.RadioPoupanca.Text = "Conta poupança";
            this.RadioPoupanca.UseVisualStyleBackColor = true;
            // 
            // NumAgencia
            // 
            this.NumAgencia.Location = new System.Drawing.Point(18, 42);
            this.NumAgencia.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumAgencia.Name = "NumAgencia";
            this.NumAgencia.ReadOnly = true;
            this.NumAgencia.Size = new System.Drawing.Size(120, 23);
            this.NumAgencia.TabIndex = 5;
            // 
            // TxtNumeroDeConta
            // 
            this.TxtNumeroDeConta.Location = new System.Drawing.Point(18, 105);
            this.TxtNumeroDeConta.Name = "TxtNumeroDeConta";
            this.TxtNumeroDeConta.Size = new System.Drawing.Size(338, 23);
            this.TxtNumeroDeConta.TabIndex = 4;
            this.TxtNumeroDeConta.Enter += new System.EventHandler(this.TxtNumeroDeConta_Enter);
            this.TxtNumeroDeConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDeConta_KeyPress);
            this.TxtNumeroDeConta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNumeroDeConta_KeyUp);
            this.TxtNumeroDeConta.Leave += new System.EventHandler(this.TxtNumeroDeConta_Leave);
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
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agência";
            // 
            // BtEntrar
            // 
            this.BtEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtEntrar.Location = new System.Drawing.Point(281, 222);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtEntrar.TabIndex = 0;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.UseVisualStyleBackColor = true;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1045, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "© BANCO FIC";
            // 
            // LoginContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginContas";
            this.Text = "LoginContas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAgencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioCorrente;
        private System.Windows.Forms.RadioButton RadioPoupanca;
        private System.Windows.Forms.NumericUpDown NumAgencia;
        private System.Windows.Forms.TextBox TxtNumeroDeConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.Label label4;
    }
}