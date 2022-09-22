using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class OpcoesDeConta : Form
    {
        Conta conta;
        double limite;

        public OpcoesDeConta(Conta conta1, double limiteDeEmprestimo)
        {
            limite = limiteDeEmprestimo;
            conta = conta1;
            InitializeComponent();
        }

        private void BtOpcoesDeConta_Load(object sender, EventArgs e)
        {
            ExibirNome.Text = $"Titular: {conta.Titular}";
            ExibirAgenciaENumero.Text = $"agencia e Nº de conta: {conta.Agencia} - {conta.Numero}";
            ExibirSaldo.Text = $"Saldo: {conta.Saldo.ToString("F2")}";
            if (conta.Id == 1) { BtRender.Visible = false; }
            else { BtEmprestimo.Visible = false; }
        }

        private void BtDepositar_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito(conta);
            deposito.Show();
            this.Visible = false;
        }

        private void BtSacar_Click(object sender, EventArgs e)
        {
            Saque saque = new Saque(conta);
            saque.Show();
            this.Visible = false;
        }

        private void BtEmprestimos_Click(object sender, EventArgs e)
        {
            try
            {
                    ContaCorrente corrente = new ContaCorrente(conta.Titular, conta.Agencia, conta.Numero, conta.Cpf, conta.Saldo, limite);
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
            conta.Depositar(poupanca.Render(conta.Saldo));
            BtOpcoesDeConta_Load(sender, e);
            poupanca.SetConta(conta.Titular, conta.Agencia, conta.Numero, conta.Cpf, conta.Saldo, 1);
            salvar.AtualizarContaPoupanca(poupanca);
        }
    }
}
