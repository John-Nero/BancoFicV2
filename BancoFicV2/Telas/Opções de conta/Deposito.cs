using System;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Deposito : Form
    {
        private Conta Conta;
        private ContaCorrente Corrente = new ContaCorrente();
        private ContaPoupanca Poupanca = new ContaPoupanca();
        private SalvarELer Salvar = new SalvarELer();
        private ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();

        double Limite;

        public Deposito(Conta conta, double limite)
        {
            Limite = limite;
            Conta = conta;
            InitializeComponent();
        }

        private void BtDepositar_Click(object sender, EventArgs e)
        {
            if (Conta.Tipo == TipoDeConta.ContaPoupanca)
            {

                try
                {
                    Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, Conta.Tipo);
                    Poupanca.Depositar(double.Parse(TxtValor.Text));
                    Salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, Poupanca);
                    MessageBox.Show($"Seu saldo atual é de {Poupanca.Saldo.ToString("F2")}, Clique em OK para retornar a tela de opções",
                           "Deposito concluido",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.None);
                    Conta = null;
                    OpcoesDeConta opcoes = new OpcoesDeConta(Poupanca, 0);
                    opcoes.Show();
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                           "Desculpe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }
            }
            else if (Conta.Tipo == TipoDeConta.ContaCorrente)
            {
                try
                {
                    Corrente.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, Conta.Tipo);
                    Corrente.SetLimitEmprestimo(Limite);
                    Corrente.Depositar(double.Parse(TxtValor.Text));
                    Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, Corrente);
                    MessageBox.Show($"Seu saldo atual é de {Corrente.Saldo.ToString("F2")}, Clique em OK para retornar a tela de opções",
                               "Deposito concluido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
                    Conta = null;
                    OpcoesDeConta opcoes = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
                    opcoes.Show();
                    this.Visible = false;
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

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            if (Conta.Tipo == TipoDeConta.ContaPoupanca)
            {
                Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, Conta.Tipo);
                OpcoesDeConta opcoesDeConta = new OpcoesDeConta(Poupanca, 0);
                opcoesDeConta.Show();
                this.Visible = false;
            }
            else
            {
                Corrente.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, Conta.Tipo);
                OpcoesDeConta opcoesDeConta = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
                opcoesDeConta.Show();
                this.Visible = false;
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valorFinal = Validacao.ValidarNumeros(e, 2);

            TxtValor.Text = valorFinal;
        }

        private void TxtValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8 && e.KeyValue != 46)
            {
                if (TxtValor.Text.Length != 0) { TxtValor.Text = TxtValor.Text.Remove(0, 1); }
            }
        }


    }

}
