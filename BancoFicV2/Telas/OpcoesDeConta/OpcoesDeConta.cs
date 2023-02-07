using BancoFicV2.Contas;
using BancoFicV2.Enums;
using System;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class OpcoesDeConta : Form
    {
        Conta Conta;
        double Limite;

        public OpcoesDeConta(Conta conta1, double limiteDeEmprestimo)
        {
            Limite = limiteDeEmprestimo;
            Conta = conta1;
            InitializeComponent();
        }

        private void BtOpcoesDeConta_Load(object sender, EventArgs e)
        {
            ExibirNome.Text = $"Titular: {Conta.Titular}";
            ExibirAgênica.Text = $"Agencia: {(int)Conta.Agencia}  {Conta.Agencia.ToString().Replace("_", " ")}";
            ExibirNumero.Text = $"Nº de conta: {Conta.Numero}";
            ExibirSaldo.Text = $"Saldo: {Conta.Saldo.ToString("F2")}";
            if (Conta.Tipo == TipoDeConta.ContaCorrente) { BtRender.Visible = false; }
            else { BtEmprestimo.Visible = false; }
        }

        private void BtLogOff_Click(object sender, EventArgs e)
        {
            OpcoesIniciais OpcoesIniciais = new OpcoesIniciais();
            OpcoesIniciais.Show();
            this.Visible = false;
        }

        private void BtDepositar_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito(Conta, Limite);
            deposito.Show();
            this.Visible = false;
        }

        private void BtSacar_Click(object sender, EventArgs e)
        {
            Saque saque = new Saque(Conta, Limite);
            saque.Show();
            this.Visible = false;
        }

        private void BtTransferir_Click(object sender, EventArgs e)
        {
            Transferencia transferencia = new Transferencia(Conta, Limite);
            transferencia.Show();
            this.Dispose();
        }

        private void BtEmprestimos_Click(object sender, EventArgs e)
        {
            try
            {
                ContaCorrente corrente = new ContaCorrente(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, TipoDeConta.ContaCorrente, Conta.Saldo, Limite);
                Emprestimo Emprestimo = new Emprestimo(corrente);
                Emprestimo.Show();
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

        private void BtRender_Click(object sender, EventArgs e)
        {
            ContaPoupanca poupanca = new ContaPoupanca();
            SalvarELer salvar = new SalvarELer();
            Conta.Depositar(poupanca.Render(Conta.Saldo));
            BtOpcoesDeConta_Load(sender, e);
            poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, TipoDeConta.ContaPoupanca);
            salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, poupanca);
        }

        
    }
}
