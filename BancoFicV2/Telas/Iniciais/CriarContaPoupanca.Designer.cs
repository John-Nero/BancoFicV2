
namespace BancoFicV2
{
    partial class CriarContaPoupanca
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
            this.LbNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.LbEstado = new System.Windows.Forms.Label();
            this.SelecEstado = new System.Windows.Forms.ComboBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.LbCpf = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Location = new System.Drawing.Point(6, 18);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(40, 15);
            this.LbNome.TabIndex = 0;
            this.LbNome.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(6, 36);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(233, 23);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            this.TxtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Entrar);
            this.groupBox1.Controls.Add(this.LbEstado);
            this.groupBox1.Controls.Add(this.SelecEstado);
            this.groupBox1.Controls.Add(this.TxtCpf);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.LbCpf);
            this.groupBox1.Controls.Add(this.LbNome);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(243, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criando sua conta poupança";
            // 
            // Entrar
            // 
            this.Entrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Entrar.Location = new System.Drawing.Point(164, 210);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 6;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // LbEstado
            // 
            this.LbEstado.AutoSize = true;
            this.LbEstado.Location = new System.Drawing.Point(8, 142);
            this.LbEstado.Name = "LbEstado";
            this.LbEstado.Size = new System.Drawing.Size(42, 15);
            this.LbEstado.TabIndex = 5;
            this.LbEstado.Text = "Estado";
            // 
            // SelecEstado
            // 
            this.SelecEstado.FormattingEnabled = true;
            this.SelecEstado.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Bahia",
            "Ceará",
            "Rio Grande do Sul",
            "Santa Catarina"});
            this.SelecEstado.Location = new System.Drawing.Point(6, 160);
            this.SelecEstado.Name = "SelecEstado";
            this.SelecEstado.Size = new System.Drawing.Size(233, 23);
            this.SelecEstado.TabIndex = 3;
            this.SelecEstado.Text = "Selecione um Estado";
            this.SelecEstado.SelectedIndexChanged += new System.EventHandler(this.SelecEstado_SelectedIndexChanged);
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(6, 95);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(233, 23);
            this.TxtCpf.TabIndex = 4;
            this.TxtCpf.Enter += new System.EventHandler(this.TxtCpf_Enter);
            this.TxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpf_KeyPress);
            this.TxtCpf.Leave += new System.EventHandler(this.TxtCpf_Leave);
            // 
            // LbCpf
            // 
            this.LbCpf.AutoSize = true;
            this.LbCpf.Location = new System.Drawing.Point(6, 77);
            this.LbCpf.Name = "LbCpf";
            this.LbCpf.Size = new System.Drawing.Size(28, 15);
            this.LbCpf.TabIndex = 3;
            this.LbCpf.Text = "CPF";
            // 
            // CriarContaPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(754, 475);
            this.Controls.Add(this.groupBox1);
            this.Name = "CriarContaPoupanca";
            this.Text = "CriarContaPoupança";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.Label LbCpf;
        private System.Windows.Forms.Label LbEstado;
        private System.Windows.Forms.ComboBox SelecEstado;
        private System.Windows.Forms.Button Entrar;
    }
}