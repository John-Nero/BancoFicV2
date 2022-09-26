using System;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Saque : Form
    {
        Conta Conta;
        double Limite;
        ContaCorrente Corrente = new ContaCorrente();
        ContaPoupanca Poupanca = new ContaPoupanca();
        SalvarELer Salvar = new SalvarELer();

        public Saque(Conta conta,double limite)
        {
            Limite = limite;
            Conta = conta;
            InitializeComponent();
        }

        private void BtSacar_Click(object sender, EventArgs e)
        {
            if (Conta.Id == 1)
            {
                try
                {
                    Poupanca.SetConta(Conta.Titular, Conta.Agencia,Conta.Numero , Conta.Cpf, Conta.Saldo, Conta.Id);
                    Poupanca.Sacar(double.Parse(txtValor.Text));
                    Salvar.AtualizarContaPoupanca(Poupanca);
                    MessageBox.Show("Clique em OK para retornar a tela de opções",
                           "Saque concluido",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.None);
                    Conta = null;
                    OpcoesDeConta opcoes = new OpcoesDeConta(Poupanca,0);
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
                    Corrente.Sacar(double.Parse(txtValor.Text));
                    Salvar.AtualizarContaCorrente(Corrente);
                    MessageBox.Show("Clique em OK para retornar a tela de opções",
                               "Saque concluido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
                    Conta = null;
                    OpcoesDeConta opcoes = new OpcoesDeConta(Corrente,Limite);
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
            if (Conta.Id == 1)
            {
                Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, 1);
                OpcoesDeConta opcoesDeConta = new OpcoesDeConta(Poupanca, 0);
                opcoesDeConta.Show();
                this.Visible = false;
            }
            else
            {
                Corrente.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, 2);
                OpcoesDeConta opcoesDeConta = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
                opcoesDeConta.Show();
                this.Visible = false;
            }
        }
    }
}
