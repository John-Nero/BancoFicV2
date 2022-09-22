using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class CriarContaCorrente : Form
    {
        int NumeroAgencia;
        SalvarELer Salvar = new SalvarELer();
        ContaCorrente Corrente = new ContaCorrente();
        int confirmação;
        public CriarContaCorrente()
        {
            InitializeComponent();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
            retornarNumero:
                int numero = random.Next(1000, 10000);
                Salvar.TxtParaCorrentes();
                foreach (ContaCorrente Conta in Salvar.LIstaDasCorrentes)
                {
                    if (Conta.Numero == numero && numero.ToString().Length != 4)
                    {
                        goto retornarNumero;
                    }
                    else { break; }
                }

                if (TxtNome.Text.Length < 3 || TxtNome.Text.Length >= 15)
                {
                    MessageBox.Show("Digite entre Três e quinze caracteres",
                        "Nome muito curto ou muito longo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    confirmação++;
                }

                if (TxtCpf.Text.Length != 11)
                {
                    MessageBox.Show("Confirme se digitou seu CPF corretamente",
                        "CPF invalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    confirmação++;
                }
                if (confirmação != 2)
                {
                    foreach (ContaCorrente Conta in Salvar.LIstaDasCorrentes)
                    {

                        if (decimal.Parse(TxtCpf.Text) == Conta.Cpf)
                        {
                            MessageBox.Show("Para acessar uma conta já existente acesse a opção login na tela inicial",
                                "Esse CPF já consta no sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                    }

                    Corrente.SetConta(TxtNome.Text, NumeroAgencia, numero, decimal.Parse(TxtCpf.Text), 0, 2);
                    Salvar.AtualizarContaCorrente(Corrente);

                    MessageBox.Show("Clique em OK para ser redirecionado ao Menu de opções de contas",
                                "Conta criada com sucesso!",
                            MessageBoxButtons.OK);
                    OpcoesDeConta Opcoes = new OpcoesDeConta(Corrente, 500);
                    Opcoes.Show();
                    this.Visible = false;
                }
                confirmação = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                           "Desculpe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void SelecEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelecEstado.Text)
            {
                case "São Paulo":
                NumeroAgencia = 1;
                break;

                case "Rio de Janeiro ":
                NumeroAgencia = 2;
                break;

                case "Bahia":
                NumeroAgencia = 3;
                break;

                case "Ceará":
                NumeroAgencia = 4;
                break;

                case "Rio Grande do Sul":
                NumeroAgencia = 5;
                break;

                case "Santa Catarina":
                NumeroAgencia = 6;
                break;
            }
        }

        //Personalização do campo de texto
        private void TxtNome_Enter(object sender, EventArgs e)
        {
            TxtNome.BackColor = Color.LightBlue;
        }
        private void TxtNome_Leave(object sender, EventArgs e)
        {
            TxtNome.BackColor = Color.White;
        }
        private void TxtCpf_Enter(object sender, EventArgs e)
        {
            TxtCpf.BackColor = Color.LightBlue;
        }
        private void TxtCpf_Leave(object sender, EventArgs e)
        {
            TxtCpf.BackColor = Color.White;
        }

        //Validação de tipo de caracter
        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido");
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido, digite apenas letras");

            }
        }

        private void CriarContaCorrente_Load(object sender, EventArgs e)
        {

        }
    }
}
