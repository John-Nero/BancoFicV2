﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class LoginCorrente : Form
    {
        public LoginCorrente()
        {
            InitializeComponent();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            SalvarELer Salvar = new SalvarELer();
            Salvar.JsonParaCorrentes();
            foreach (ContaCorrente conta in Salvar.LIstaDasCorrentes)
            {
                if (conta.Agencia == numAgencia.Value && conta.Numero == int.Parse(txtNumerodeconta.Text))
                {
                    MessageBox.Show("Clique em OK para continuar",
                               $"Seja Bem vindo {conta.Titular}",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
                    conta.SetId(2);

                    var opcoesdeconta = new OpcoesDeConta(conta, conta.LimiteEmprestimo);
                    opcoesdeconta.Show();
                    this.Visible = false;
                    break;
                }
                else
                {
                    MessageBox.Show("Verifique se digitou corretamente os dados",
                             $"Agencia ou Numero de conta incorreto",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                    txtNumerodeconta.Focus();
                }
            }
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Opcoesiniciais opcoesiniciais = new Opcoesiniciais();
            opcoesiniciais.Show();
            this.Visible = false;
        }

        //Personalização do campo de texto
        private void txtNumerodeconta_Enter(object sender, EventArgs e) { txtNumerodeconta.BackColor = Color.LightBlue; }
       
        private void txtNumerodeconta_Leave(object sender, EventArgs e) { txtNumerodeconta.BackColor = Color.White; }

        private void numAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido");
            }
        }

        private void txtNumerodeconta_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido");
            }
        }

        
    }
    
}
