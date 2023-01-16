using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class CriarConta : Form
    {
        private Agencias Agencia;
        private SalvarELer Salvar = new SalvarELer();
        private ContaCorrente Corrente = new ContaCorrente();
        private ContaPoupanca Poupanca = new ContaPoupanca();
        private ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();

        public CriarConta()
        {
            InitializeComponent();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {

            int ConfirmacaoDeTamanhoNome = 0;
            int ConfirmacaoDeTamanhoCpf = 0;
            int ValidaAgencia = 0;
            string menssagem = "Os campos: ";
            bool CpfValido = false;
            Random random = new Random();
            CPFCNPJ.IMain ValidacaoDeCpf = new CPFCNPJ.Main();

            if (RadioCorrente.Checked)
            {
            retornarNumero:

                //Geração de numero aleatório para conta
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

                //Validação de tamanho do nome
                if (TxtNome.Text.Length < 3 || TxtNome.Text.Length >= 15)
                {
                    ConfirmacaoDeTamanhoNome++; menssagem += "Nome, ";
                }

                //Validação do tamanho do CPF
                if (TxtCpf.Text.Length != 11)
                {
                    ConfirmacaoDeTamanhoCpf++; menssagem += "CPF, ";
                }

                //Validação do CPF
                if (TxtCpf.Text.Length == 11)
                {
                    CpfValido = ValidacaoDeCpf.IsValidCPFCNPJ(TxtCpf.Text);

                    if (CpfValido == false)
                    {
                        menssagem += "CPF, ";
                    }
                }

                //Confirmação de seleção de agencia
                if (Agencia == 0)
                {
                    ValidaAgencia++; menssagem += $"Estado ";
                }

                //Menssagem de error
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
                        MessageBox.Show("Para acessar uma conta já existente acesse a opção OpcoesIniciais na tela inicial",
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

            if (RadioPoupanca.Checked)
            {
            retornarNumero:

                //Geração do numero aleatório para conta
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

                //Validação do tamanho do nome
                if (TxtNome.Text.Length < 3 || TxtNome.Text.Length >= 15)
                {
                    ConfirmacaoDeTamanhoNome++; menssagem += "Nome, ";
                }

                //Validação do tamanho do CPF
                if (TxtCpf.Text.Length != 11)
                {
                    ConfirmacaoDeTamanhoCpf++; menssagem += "CPF, ";
                }

                //Validação do CPF
                if (TxtCpf.Text.Length == 11)
                {
                    CpfValido = ValidacaoDeCpf.IsValidCPFCNPJ(TxtCpf.Text);

                    if (CpfValido == false)
                    {
                        menssagem += "CPF, ";
                    }
                }

                //Confirmação da seleção de uma agencia
                if (Agencia == 0)
                {
                    ValidaAgencia++; menssagem += $"Estado ";
                }

                //Menssagem de error
                if (CpfValido == false || ConfirmacaoDeTamanhoNome == 1 || ConfirmacaoDeTamanhoCpf == 1 || ValidaAgencia == 1)
                {
                    menssagem += "estão com irregularidades, confirme os dados e reenvie o formulario";
                    MessageBox.Show(menssagem,
                              "Confirme se digitou corretamente os dados a seguir",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                    goto avacoDeErro;
                }

                foreach (ContaPoupanca Conta in Salvar.LIstaDasPoupancas)
                {

                    if (decimal.Parse(TxtCpf.Text) == Conta.Cpf)
                    {
                        MessageBox.Show("Para acessar uma conta já existente acesse a opção OpcoesIniciais na tela inicial",
                                        "Esse CPF já consta no sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        goto avacoDeErro;
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

            if (RadioCorrente.Checked != true && RadioPoupanca.Checked != true)
            {
                MessageBox.Show("Tipo de Conta não selecionado,por favor selecione um para prosseguir",
                             $"Verifique se selecionou o tipo de conta",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }

        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            var OpcoesIniciais = new OpcoesIniciais();
            OpcoesIniciais.Show();
            this.Visible = false;
        }

        private void ComboBoxSelecEstado_SelectedIndexChanged(object sender, EventArgs e)
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

        //Validações de caracteres digitados no campo Nome
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valorFinal = Validacao.ValidarLetra(e);

            TxtNome.Text = valorFinal;
        }

        private void TxtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8 && e.KeyValue != 46)
            {
                {
                    if (TxtNome.Text.Length != 0) { TxtNome.Text = TxtNome.Text.Remove(0, 1); }
                }
            }
        }

        //Validações de caracteres digitados no campo Cpf
        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valorFinal = Validacao.ValidarNumeros(e, 1);
            TxtCpf.Text = valorFinal;
        }

        private void TxtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8 && e.KeyValue != 46)
            {
                if (TxtCpf.Text.Length != 0) { TxtCpf.Text = TxtCpf.Text.Remove(0, 1); }
            }
        }

        //Personalizações para os campos de texto
        private void TxtNome_Enter(object sender, EventArgs e) { TxtNome.BackColor = Color.LightBlue; }
        private void TxtNome_Leave(object sender, EventArgs e) { TxtNome.BackColor = Color.White; }
        private void TxtCpf_Enter(object sender, EventArgs e) { TxtCpf.BackColor = Color.LightBlue; }
        private void TxtCpf_Leave(object sender, EventArgs e) { TxtCpf.BackColor = Color.White; }
    }
}
