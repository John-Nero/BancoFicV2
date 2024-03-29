﻿
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
            this.BtTransferir = new System.Windows.Forms.Button();
            this.BtRender = new System.Windows.Forms.Button();
            this.BtEmprestimo = new System.Windows.Forms.Button();
            this.BtSacar = new System.Windows.Forms.Button();
            this.BtDepositar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExibirAgênica = new System.Windows.Forms.Label();
            this.ExibirSaldo = new System.Windows.Forms.Label();
            this.ExibirNumero = new System.Windows.Forms.Label();
            this.ExibirNome = new System.Windows.Forms.Label();
            this.ExbirLimite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtLogOff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.BtTransferir);
            this.groupBox1.Controls.Add(this.BtRender);
            this.groupBox1.Controls.Add(this.BtEmprestimo);
            this.groupBox1.Controls.Add(this.BtSacar);
            this.groupBox1.Controls.Add(this.BtDepositar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(427, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma opção";
            // 
            // BtTransferir
            // 
            this.BtTransferir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtTransferir.Location = new System.Drawing.Point(6, 159);
            this.BtTransferir.Name = "BtTransferir";
            this.BtTransferir.Size = new System.Drawing.Size(151, 37);
            this.BtTransferir.TabIndex = 5;
            this.BtTransferir.Text = "Transferir";
            this.BtTransferir.UseVisualStyleBackColor = true;
            this.BtTransferir.Click += new System.EventHandler(this.BtTransferir_Click);
            // 
            // BtRender
            // 
            this.BtRender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtRender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtRender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtRender.Location = new System.Drawing.Point(6, 116);
            this.BtRender.Name = "BtRender";
            this.BtRender.Size = new System.Drawing.Size(151, 37);
            this.BtRender.TabIndex = 4;
            this.BtRender.Text = "Render";
            this.BtRender.UseVisualStyleBackColor = true;
            this.BtRender.Click += new System.EventHandler(this.BtRender_Click);
            // 
            // BtEmprestimo
            // 
            this.BtEmprestimo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtEmprestimo.Location = new System.Drawing.Point(6, 116);
            this.BtEmprestimo.Name = "BtEmprestimo";
            this.BtEmprestimo.Size = new System.Drawing.Size(151, 37);
            this.BtEmprestimo.TabIndex = 3;
            this.BtEmprestimo.Text = "Emprestimo";
            this.BtEmprestimo.UseVisualStyleBackColor = true;
            this.BtEmprestimo.Click += new System.EventHandler(this.BtEmprestimos_Click);
            // 
            // BtSacar
            // 
            this.BtSacar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtSacar.Location = new System.Drawing.Point(6, 73);
            this.BtSacar.Name = "BtSacar";
            this.BtSacar.Size = new System.Drawing.Size(151, 37);
            this.BtSacar.TabIndex = 1;
            this.BtSacar.Text = "Sacar";
            this.BtSacar.UseVisualStyleBackColor = true;
            this.BtSacar.Click += new System.EventHandler(this.BtSacar_Click);
            // 
            // BtDepositar
            // 
            this.BtDepositar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtDepositar.Location = new System.Drawing.Point(6, 30);
            this.BtDepositar.Name = "BtDepositar";
            this.BtDepositar.Size = new System.Drawing.Size(151, 37);
            this.BtDepositar.TabIndex = 0;
            this.BtDepositar.Text = "Depositar";
            this.BtDepositar.UseVisualStyleBackColor = true;
            this.BtDepositar.Click += new System.EventHandler(this.BtDepositar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.ExibirAgênica);
            this.groupBox2.Controls.Add(this.ExibirSaldo);
            this.groupBox2.Controls.Add(this.ExibirNumero);
            this.groupBox2.Controls.Add(this.ExibirNome);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(699, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados bancários";
            // 
            // ExibirAgênica
            // 
            this.ExibirAgênica.AutoSize = true;
            this.ExibirAgênica.Location = new System.Drawing.Point(12, 52);
            this.ExibirAgênica.Name = "ExibirAgênica";
            this.ExibirAgênica.Size = new System.Drawing.Size(0, 15);
            this.ExibirAgênica.TabIndex = 3;
            // 
            // ExibirSaldo
            // 
            this.ExibirSaldo.AutoSize = true;
            this.ExibirSaldo.Location = new System.Drawing.Point(12, 95);
            this.ExibirSaldo.Name = "ExibirSaldo";
            this.ExibirSaldo.Size = new System.Drawing.Size(0, 15);
            this.ExibirSaldo.TabIndex = 2;
            // 
            // ExibirNumero
            // 
            this.ExibirNumero.AutoSize = true;
            this.ExibirNumero.Location = new System.Drawing.Point(12, 73);
            this.ExibirNumero.Name = "ExibirNumero";
            this.ExibirNumero.Size = new System.Drawing.Size(0, 15);
            this.ExibirNumero.TabIndex = 1;
            // 
            // ExibirNome
            // 
            this.ExibirNome.AutoSize = true;
            this.ExibirNome.Location = new System.Drawing.Point(12, 30);
            this.ExibirNome.Name = "ExibirNome";
            this.ExibirNome.Size = new System.Drawing.Size(0, 15);
            this.ExibirNome.TabIndex = 0;
            // 
            // ExbirLimite
            // 
            this.ExbirLimite.Location = new System.Drawing.Point(0, 0);
            this.ExbirLimite.Name = "ExbirLimite";
            this.ExbirLimite.Size = new System.Drawing.Size(100, 23);
            this.ExbirLimite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1053, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "© BANCO FIC";
            // 
            // BtLogOff
            // 
            this.BtLogOff.Location = new System.Drawing.Point(5, 5);
            this.BtLogOff.Name = "BtLogOff";
            this.BtLogOff.Size = new System.Drawing.Size(75, 23);
            this.BtLogOff.TabIndex = 5;
            this.BtLogOff.Text = "LogOff";
            this.BtLogOff.UseVisualStyleBackColor = true;
            this.BtLogOff.Click += new System.EventHandler(this.BtLogOff_Click);
            // 
            // OpcoesDeConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.ControlBox = false;
            this.Controls.Add(this.BtLogOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "OpcoesDeConta";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "OpcoesDeConta";
            this.Load += new System.EventHandler(this.BtOpcoesDeConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtEmprestimo;
        private System.Windows.Forms.Button BtSacar;
        private System.Windows.Forms.Button BtDepositar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ExibirSaldo;
        private System.Windows.Forms.Label ExibirNumero;
        private System.Windows.Forms.Label ExibirNome;
        private System.Windows.Forms.Label ExbirLimite;
        private System.Windows.Forms.Button BtRender;
        private System.Windows.Forms.Button BtTransferir;
        private System.Windows.Forms.Label ExibirAgênica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtLogOff;
    }
}