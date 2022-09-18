
namespace BancoFicV2
{
    partial class OpcoesDeConta
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
            this.empestimos = new System.Windows.Forms.Button();
            this.ConsultarSaldo = new System.Windows.Forms.Button();
            this.Sacar = new System.Windows.Forms.Button();
            this.Depositar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empestimos);
            this.groupBox1.Controls.Add(this.ConsultarSaldo);
            this.groupBox1.Controls.Add(this.Sacar);
            this.groupBox1.Controls.Add(this.Depositar);
            this.groupBox1.Location = new System.Drawing.Point(339, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma opção";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // empestimos
            // 
            this.empestimos.Location = new System.Drawing.Point(6, 159);
            this.empestimos.Name = "empestimos";
            this.empestimos.Size = new System.Drawing.Size(151, 52);
            this.empestimos.TabIndex = 3;
            this.empestimos.Text = "Emprestimo(APENAS PARA CONTA CORRENTE)";
            this.empestimos.UseVisualStyleBackColor = true;
            this.empestimos.Click += new System.EventHandler(this.empestimos_Click);
            // 
            // ConsultarSaldo
            // 
            this.ConsultarSaldo.Location = new System.Drawing.Point(6, 116);
            this.ConsultarSaldo.Name = "ConsultarSaldo";
            this.ConsultarSaldo.Size = new System.Drawing.Size(151, 37);
            this.ConsultarSaldo.TabIndex = 2;
            this.ConsultarSaldo.Text = "Consultar saldo";
            this.ConsultarSaldo.UseVisualStyleBackColor = true;
            this.ConsultarSaldo.Click += new System.EventHandler(this.ConsultarSaldo_Click);
            // 
            // Sacar
            // 
            this.Sacar.Location = new System.Drawing.Point(6, 73);
            this.Sacar.Name = "Sacar";
            this.Sacar.Size = new System.Drawing.Size(151, 37);
            this.Sacar.TabIndex = 1;
            this.Sacar.Text = "Sacar";
            this.Sacar.UseVisualStyleBackColor = true;
            this.Sacar.Click += new System.EventHandler(this.Sacar_Click);
            // 
            // Depositar
            // 
            this.Depositar.Location = new System.Drawing.Point(6, 30);
            this.Depositar.Name = "Depositar";
            this.Depositar.Size = new System.Drawing.Size(151, 37);
            this.Depositar.TabIndex = 0;
            this.Depositar.Text = "Depositar";
            this.Depositar.UseVisualStyleBackColor = true;
            this.Depositar.Click += new System.EventHandler(this.Depositar_Click);
            // 
            // OpcoesDeConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "OpcoesDeConta";
            this.Text = "OpcoesDeConta";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button empestimos;
        private System.Windows.Forms.Button ConsultarSaldo;
        private System.Windows.Forms.Button Sacar;
        private System.Windows.Forms.Button Depositar;
    }
}