using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Transferencia : Form
    {
        Conta Conta;
        ContaCorrente Corrente = new ContaCorrente();
        ContaPoupanca Poupanca = new ContaPoupanca();
        SalvarELer Salvar = new SalvarELer();
        public Transferencia(Conta conta, double limite)
        {

            Conta = conta;
            InitializeComponent();
        }

        private void BtTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioPoupanca.Checked == true)
                {
                    Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, Conta.Id);
                    Salvar.LerContas(TipoDeConta.ContaPoupanca);

                    foreach (ContaPoupanca conta in Salvar.LIstaDasPoupancas)
                    {
                        if (int.Parse(TxtAgencia.Text) == conta.Agencia && int.Parse(TxtNumero.Text) == conta.Numero)
                        {
                            conta.Depositar(double.Parse(TxtValor.Text));
                            Poupanca.Sacar(double.Parse(TxtValor.Text));
                            Salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, conta);
                            Salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, Poupanca);
                            break;
                        }
                    }
                }

                else if (RadioCorrente.Checked == true)
                {
                    Corrente.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, Conta.Id);
                    Salvar.LerContas(TipoDeConta.ContaCorrente);

                    foreach (ContaCorrente conta in Salvar.LIstaDasCorrentes)
                    {
                        if (int.Parse(TxtAgencia.Text) == conta.Agencia && int.Parse(TxtNumero.Text) == conta.Numero)
                        {
                            conta.Depositar(double.Parse(TxtValor.Text));
                            Corrente.Sacar(double.Parse(TxtValor.Text));
                            Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, conta);
                            Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, Corrente);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Para prosseguir selecione o tipo de conta do destinatario",
                       "Selecione uma opção de conta",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
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
