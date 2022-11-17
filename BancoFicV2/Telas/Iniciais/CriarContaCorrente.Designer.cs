
namespace BancoFicV2
{
    partial class CriarContaCorrente
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
            base.Close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtEntrar = new System.Windows.Forms.Button();
            this.LbEstado = new System.Windows.Forms.Label();
            this.ComboBoxSelecEstado = new System.Windows.Forms.ComboBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LbCpf = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.BtEntrar);
            this.groupBox1.Controls.Add(this.LbEstado);
            this.groupBox1.Controls.Add(this.ComboBoxSelecEstado);
            this.groupBox1.Controls.Add(this.TxtCpf);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.LbCpf);
            this.groupBox1.Controls.Add(this.LbNome);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(427, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 255);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criando sua conta corrente";
            // 
            // BtEntrar
            // 
            this.BtEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtEntrar.Location = new System.Drawing.Point(164, 210);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtEntrar.TabIndex = 7;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.UseVisualStyleBackColor = true;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
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
            // ComboBoxSelecEstado
            // 
            this.ComboBoxSelecEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSelecEstado.FormattingEnabled = true;
            this.ComboBoxSelecEstado.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Bahia",
            "Ceará",
            "Rio Grande do Sul",
            "Santa Catarina"});
            this.ComboBoxSelecEstado.Location = new System.Drawing.Point(6, 160);
            this.ComboBoxSelecEstado.Name = "ComboBoxSelecEstado";
            this.ComboBoxSelecEstado.Size = new System.Drawing.Size(233, 23);
            this.ComboBoxSelecEstado.TabIndex = 3;
            this.ComboBoxSelecEstado.SelectedIndexChanged += new System.EventHandler(this.SelecEstado_SelectedIndexChanged);
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(6, 95);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.PlaceholderText = "Digite apenas os números, sem os pontos";
            this.TxtCpf.Size = new System.Drawing.Size(233, 23);
            this.TxtCpf.TabIndex = 4;
            this.TxtCpf.Enter += new System.EventHandler(this.TxtCpf_Enter);
            this.TxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpf_KeyPress);
            this.TxtCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCpf_KeyUp);
            this.TxtCpf.Leave += new System.EventHandler(this.TxtCpf_Leave);
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtNome.Location = new System.Drawing.Point(6, 36);
            this.TxtNome.MaxLength = 15;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.PlaceholderText = "Máximo de 15 caracteres e mínimo de 3";
            this.TxtNome.Size = new System.Drawing.Size(233, 23);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            this.TxtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyUp);
            this.TxtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
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
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Location = new System.Drawing.Point(6, 18);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(40, 15);
            this.LbNome.TabIndex = 0;
            this.LbNome.Text = "Nome";
            // 
            // BtVoltar
            // 
            this.BtVoltar.Location = new System.Drawing.Point(13, 13);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtVoltar.TabIndex = 4;
            this.BtVoltar.Text = "Voltar";
            this.BtVoltar.UseVisualStyleBackColor = true;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // CriarContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CriarContaCorrente";
            this.Text = "CriarContaCorrente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbEstado;
        private System.Windows.Forms.ComboBox ComboBoxSelecEstado;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LbCpf;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.Button BtVoltar;
    }
}