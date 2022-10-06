using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class CriarContaPoupanca : Form
    {
        int Agencia;
        SalvarELer Salvar = new SalvarELer();
        ContaPoupanca Poupanca = new ContaPoupanca();

        public CriarContaPoupanca()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {

            try
            {
                Random random = new Random();
            retornarNumero:
                int numero = random.Next(1000, 10000);
                //Salvar.JsonParaPoupancas();
                if (Salvar.LIstaDasPoupancas != null)
                {
                    foreach (ContaPoupanca Conta in Salvar.LIstaDasPoupancas)
                    {
                        if (Conta.Numero == numero && Conta.Agencia == Agencia)
                        {
                            goto retornarNumero;
                        }
                        else { break; }
                    }
                }

                if (TxtNome.Text.Length < 3 || TxtNome.Text.Length >= 15)
                {
                    MessageBox.Show("Digite entre Três e quinze caracteres",
                        "Nome muito curto ou muito longo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    goto avacoDeErro;
                }

                if (TxtCpf.Text.Length != 11)
                {
                    MessageBox.Show("Confirme se digitou seu CPF corretamente",
                        "CPF invalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    goto avacoDeErro;
                }

                if (Agencia == 0)
                {
                    MessageBox.Show("Selecione um estado para prosseguir",
                                    $"Campo ESTADO vazio  ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    goto avacoDeErro;
                }
                foreach (ContaPoupanca Conta in Salvar.LIstaDasPoupancas)
                {

                    if (decimal.Parse(TxtCpf.Text) == Conta.Cpf)
                    {
                        MessageBox.Show("Para acessar uma conta já existente acesse a opção login na tela inicial",
                                        "Esse CPF já consta no sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        goto avacoDeErro;
                    }

                }

                Poupanca.SetConta(TxtNome.Text, Agencia, numero, decimal.Parse(TxtCpf.Text), 0, 1);
                Salvar.AtualizarContaPoupanca(Poupanca);

                MessageBox.Show("Clique em OK para ser redirecionado ao Menu de opções de contas",
                            "Conta criada com sucesso!",
                        MessageBoxButtons.OK);
                OpcoesDeConta Opcoes = new OpcoesDeConta(Poupanca, 0);
                Opcoes.Show();
                this.Visible = false;

            avacoDeErro:;
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
                Agencia = 1;
                break;

                case "Rio de Janeiro":
                Agencia = 2;
                break;

                case "Bahia":
                Agencia = 3;
                break;

                case "Ceará":
                Agencia = 4;
                break;

                case "Rio Grande do Sul":
                Agencia = 5;
                break;

                case "Santa Catarina":
                Agencia = 6;
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

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Opcoesiniciais opcoesiniciais = new Opcoesiniciais();
            opcoesiniciais.Show();
            this.Visible = false;
        }
    }
}