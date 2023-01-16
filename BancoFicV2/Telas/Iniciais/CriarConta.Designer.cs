
namespace BancoFicV2
{
    partial class CriarConta
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
            this.BtEntrar = new System.Windows.Forms.Button();
            this.LbEstado = new System.Windows.Forms.Label();
            this.ComboBoxSelecEstado = new System.Windows.Forms.ComboBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LbCpf = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtVoltar
            // 
            this.BtVoltar.Location = new System.Drawing.Point(12, 12);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtVoltar.TabIndex = 8;
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
            this.groupBox1.Controls.Add(this.BtEntrar);
            this.groupBox1.Controls.Add(this.LbEstado);
            this.groupBox1.Controls.Add(this.ComboBoxSelecEstado);
            this.groupBox1.Controls.Add(this.TxtCpf);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.LbCpf);
            this.groupBox1.Controls.Add(this.LbNome);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(426, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 321);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criando sua conta corrente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Selecione o tipo de conta que deseja criar";
            // 
            // RadioCorrente
            // 
            this.RadioCorrente.AutoSize = true;
            this.RadioCorrente.Location = new System.Drawing.Point(17, 250);
            this.RadioCorrente.Name = "RadioCorrente";
            this.RadioCorrente.Size = new System.Drawing.Size(104, 19);
            this.RadioCorrente.TabIndex = 16;
            this.RadioCorrente.TabStop = true;
            this.RadioCorrente.Text = "Conta corrente";
            this.RadioCorrente.UseVisualStyleBackColor = true;
            // 
            // RadioPoupanca
            // 
            this.RadioPoupanca.AutoSize = true;
            this.RadioPoupanca.Location = new System.Drawing.Point(17, 225);
            this.RadioPoupanca.Name = "RadioPoupanca";
            this.RadioPoupanca.Size = new System.Drawing.Size(113, 19);
            this.RadioPoupanca.TabIndex = 15;
            this.RadioPoupanca.TabStop = true;
            this.RadioPoupanca.Text = "Conta poupança";
            this.RadioPoupanca.UseVisualStyleBackColor = true;
            // 
            // BtEntrar
            // 
            this.BtEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtEntrar.Location = new System.Drawing.Point(164, 276);
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
            this.ComboBoxSelecEstado.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelecEstado_SelectedIndexChanged);
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(6, 95);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.PlaceholderText = "Digite apenas os números, sem os pontos";
            this.TxtCpf.Size = new System.Drawing.Size(233, 23);
            this.TxtCpf.TabIndex = 4;
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
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioCorrente;
        private System.Windows.Forms.RadioButton RadioPoupanca;
        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.Label LbEstado;
        private System.Windows.Forms.ComboBox ComboBoxSelecEstado;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LbCpf;
        private System.Windows.Forms.Label LbNome;
    }
}