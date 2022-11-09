using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class CriarContaCorrente : Form
    {
        Agencias Agencia;
        SalvarELer Salvar = new SalvarELer();
        ContaCorrente Corrente = new ContaCorrente();
        ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();

        KeyPressEventArgs Letra;
        KeyPressEventArgs Numero;

        public CriarContaCorrente()
        {
            InitializeComponent();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                int ConfirmacaoDeTamanhoNome = 0;
                int ConfirmacaoDeTamanhoCpf = 0;
                int ValidaAgencia = 0;
                string menssagem = "Os campos: ";
                bool CpfValido = false;

                Random random = new Random();
                CPFCNPJ.IMain ValidacaoDeCpf = new CPFCNPJ.Main();

            retornarNumero:

                int numero = random.Next(1000, 10000);
                Salvar.LerContas(TipoDeConta.ContaCorrente);
                if (Salvar.LIstaDasCorrentes != null)
                {
                    foreach (ContaCorrente Conta in Salvar.LIstaDasCorrentes)
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
                    ConfirmacaoDeTamanhoNome++; menssagem += "Nome, ";
                }

                if (TxtCpf.Text.Length != 11)
                {
                    ConfirmacaoDeTamanhoCpf++; menssagem += "CPF, ";
                }

                if (TxtCpf.Text.Length == 11)
                {
                    CpfValido = ValidacaoDeCpf.IsValidCPFCNPJ(TxtCpf.Text);

                    if (CpfValido == false)
                    {
                        menssagem += "CPF, ";
                    }
                }

                if (Agencia == 0)
                {
                    ValidaAgencia++; menssagem += $"Estado ";
                }

                if (CpfValido == false || ConfirmacaoDeTamanhoNome == 1 || ConfirmacaoDeTamanhoCpf == 1 || ValidaAgencia == 1)
                {
                    menssagem += "estão com irregularidades, confirme os dados e reenvie o formulario";
                    MessageBox.Show(menssagem,
                              "Confirme se digitou corretamente os dados a seguir",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                    goto avacoDeErro;
                }

                foreach (ContaCorrente Conta in Salvar.LIstaDasCorrentes)
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

                Corrente.SetConta(TxtNome.Text, Agencia, numero, long.Parse(TxtCpf.Text), 0, TipoDeConta.ContaCorrente);
                Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, Corrente);

                MessageBox.Show("Clique em OK para ser redirecionado ao Menu de opções de contas",
                            "Conta criada com sucesso!",
                        MessageBoxButtons.OK);
                OpcoesDeConta Opcoes = new OpcoesDeConta(Corrente, 0);
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
        private void TxtNome_Enter(object sender, EventArgs e) { TxtNome.BackColor = Color.LightBlue; }
        private void TxtNome_Leave(object sender, EventArgs e) { TxtNome.BackColor = Color.White; }
        private void TxtCpf_Enter(object sender, EventArgs e) { TxtCpf.BackColor = Color.LightBlue; }
        private void TxtCpf_Leave(object sender, EventArgs e) { TxtCpf.BackColor = Color.White; }

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
