using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class CriarContaPoupanca : Form
    {
        public CriarContaPoupanca()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CriarContaPoupanca_Load(object sender, EventArgs e)
        {

        }

        private void BtEntrar(object sender, EventArgs e)
        {
            SalvarELer Salvar = new SalvarELer();
            ContaPoupanca Poupanca = new ContaPoupanca();
            try
            {
                Random random = new Random();
            retornarNumero:
                int numero = random.Next(1000, 10000);
                Salvar.TxtParaPoupancas();
                foreach (ContaPoupanca Conta in Salvar.LIstaDasPoupancas)
                {
                    if (Conta.Numero == numero && numero.ToString().Length != 4)
                    {
                        goto retornarNumero;
                    }
                    else { break; }
                }


                if (TxtNome.Text.Length < 3 || TxtNome.Text.Length >= 15)

                {
                    MessageBox.Show(", digite entre 3 e quinze caracteres",
                        "Nome muito curto ou muito longo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                foreach (ContaPoupanca Conta in Salvar.LIstaDasPoupancas)
                {
                    if (TxtCpf.Text.Length < 3 || TxtCpf.Text.Length >= 15)
                    {
                        MessageBox.Show("Confirme se digitou seu CPF corretamente",
                            "CPF invalido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                    if (decimal.Parse(TxtCpf.Text) == Conta.Cpf)
                    {
                        MessageBox.Show("Para acessar uma conta já existente acesse a opção login na tela inicial",
                            "Esse CPF já consta no sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                }

                Poupanca.setNumero(numero);
                Poupanca.setTitular(TxtNome.Text);
                Poupanca.setCpf(decimal.Parse(TxtCpf.Text));
                Salvar.AtualizarContaPoupanca(Poupanca);
                
                MessageBox.Show("Clique em OK para ser redirecionado ao Menu de opções de contas",
                            "Conta criada com sucesso!",
                        MessageBoxButtons.OKCancel);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                           "Desculpe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }
    }
}
