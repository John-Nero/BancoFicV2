
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
            this.numAgencia = new System.Windows.Forms.NumericUpDown();
            this.txtNumerodeconta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtEntrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgencia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numAgencia);
            this.groupBox1.Controls.Add(this.txtNumerodeconta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtEntrar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(182, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login conta corrente";
            // 
            // numAgencia
            // 
            this.numAgencia.Location = new System.Drawing.Point(18, 42);
            this.numAgencia.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numAgencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAgencia.Name = "numAgencia";
            this.numAgencia.Size = new System.Drawing.Size(120, 23);
            this.numAgencia.TabIndex = 5;
            this.numAgencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNumerodeconta
            // 
            this.txtNumerodeconta.Location = new System.Drawing.Point(18, 105);
            this.txtNumerodeconta.Name = "txtNumerodeconta";
            this.txtNumerodeconta.Size = new System.Drawing.Size(338, 23);
            this.txtNumerodeconta.TabIndex = 4;
            this.txtNumerodeconta.Enter += new System.EventHandler(this.txtNumerodeconta_Enter);
            this.txtNumerodeconta.Leave += new System.EventHandler(this.txtNumerodeconta_Leave);
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
            // BtEntrar
            // 
            this.BtEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtEntrar.Location = new System.Drawing.Point(281, 134);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtEntrar.TabIndex = 0;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.UseVisualStyleBackColor = true;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
            // 
            // LoginCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(754, 475);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginCorrente";
            this.Text = "LoginCorrente";
            this.Load += new System.EventHandler(this.LoginCorrente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumerodeconta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNntrar;
        private System.Windows.Forms.NumericUpDown numAgencia;
        private System.Windows.Forms.Button BtEntrar;
    }
}