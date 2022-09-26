using System;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Deposito : Form
    {
        Conta Conta;
        double Limite;
        ContaCorrente Corrente = new ContaCorrente();
        ContaPoupanca Poupanca = new ContaPoupanca();
        SalvarELer Salvar = new SalvarELer();

        public Deposito(Conta conta, double limite)
        {
            Limite = limite;
            Conta = conta;
            InitializeComponent();
        }
        private void BtDepositar_Click(object sender, EventArgs e)
        {
            if (Conta.Id == 1)
            {
                try
                {
                    Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, 1);
                    Poupanca.Depositar(double.Parse(txtValor.Text));
                    Salvar.AtualizarContaPoupanca(Poupanca);
                    MessageBox.Show("Clique em OK para retornar a tela de opções",
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
            else if (Conta.Id == 2)
            {
                try
                {
                    Corrente.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, Conta.Id);
                    Corrente.SetLimitEmprestimo(Limite);
                    Corrente.Depositar(double.Parse(txtValor.Text));
                    Salvar.AtualizarContaCorrente(Corrente);
                    MessageBox.Show("Clique em OK para retornar a tela de opções",
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
    }
}
