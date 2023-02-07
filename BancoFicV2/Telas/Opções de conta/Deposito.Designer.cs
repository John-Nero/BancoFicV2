
namespace BancoFicV2
{
    partial class Deposito
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
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtDepositar = new System.Windows.Forms.Button();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.TxtValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtDepositar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(427, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizando depósito";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(6, 153);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(214, 23);
            this.TxtValor.TabIndex = 2;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            this.TxtValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtValor_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a quantidade que deseja depositar";
            // 
            // BtDepositar
            // 
            this.BtDepositar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtDepositar.Location = new System.Drawing.Point(64, 231);
            this.BtDepositar.Name = "BtDepositar";
            this.BtDepositar.Size = new System.Drawing.Size(85, 55);
            this.BtDepositar.TabIndex = 0;
            this.BtDepositar.Text = "Depositar";
            this.BtDepositar.UseVisualStyleBackColor = true;
            this.BtDepositar.Click += new System.EventHandler(this.BtDepositar_Click);
            // 
            // BtVoltar
            // 
            this.BtVoltar.Location = new System.Drawing.Point(12, 12);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtVoltar.TabIndex = 1;
            this.BtVoltar.Text = "Voltar";
            this.BtVoltar.UseVisualStyleBackColor = true;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1045, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "© BANCO FIC";
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtDepositar;
        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.Label label2;
    }
}