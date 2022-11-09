using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class CriarContaPoupanca : Form
    {
        Agencias Agencia;
        SalvarELer Salvar = new SalvarELer();
        ContaPoupanca Poupanca = new ContaPoupanca();
        ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();

        KeyPressEventArgs Letra;
        KeyPressEventArgs Numero;

        public CriarContaPoupanca()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                int ValidaNome = 0;
                int ValidaCpf = 0;
                int ValidaAgencia = 0;
                string menssagem = "Os campos: ";
                Random random = new Random();
            retornarNumero:
                int numero = random.Next(1000, 10000);
                Salvar.LerContas(TipoDeConta.ContaPoupanca);
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

                if (TxtNome.Text.Length < 3 || TxtNome.Text.Length >= 15) { ValidaNome++;menssagem += "Nome, "; }
                if (TxtCpf.Text.Length != 11) { ValidaCpf++; menssagem += "CPF, "; }
                if (Agencia == 0) { ValidaAgencia++;menssagem += $"Estado "; }
                if(ValidaNome == 1 || ValidaCpf == 1 || ValidaAgencia == 1)
                {
                    menssagem += "estão com irregularidades, confirme os dados e reenvie o formulario";
                    MessageBox.Show(menssagem,
                              "Confirme se digitou corretamente os dados a seguir",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                    goto avacoDeErro;
                }
                if (Salvar.LIstaDasPoupancas != null)
                {
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
                }
                Poupanca.SetConta(TxtNome.Text, Agencia, numero, long.Parse(TxtCpf.Text), 0, TipoDeConta.ContaPoupanca);
                Salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, Poupanca);

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

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Opcoesiniciais opcoesiniciais = new Opcoesiniciais();
            opcoesiniciais.Show();
            this.Visible = false;
        }


        private void SelecEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxSelecEstado.Text)
            {
                case "São Paulo":
                Agencia = Agencias.São_Paulo;
                break;

                case "Rio de Janeiro":
                Agencia = Agencias.Rio_de_Janeiro;
                break;

                case "Bahia":
                Agencia = Agencias.Bahia;
                break;

                case "Ceará":
                Agencia = Agencias.Ceará;
                break;

                case "Rio Grande do Sul":
                Agencia = Agencias.Rio_Grande_do_Sul;
                break;

                case "Santa Catarina":
                Agencia = Agencias.Santa_Catarina;
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
            Numero = e;
        }
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra = e;
        }

        private void TxtNome_KeyUp(object sender, KeyEventArgs e)
        {
            TxtNome.Text = Validacao.ValidarLetras(Letra);
        }

        private void TxtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            TxtCpf.Text = Validacao.ValidarNumeros(Numero);
        }
    }
}
