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
        ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();

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
                    OpcoesDeConta opcoesDeConta = new OpcoesDeConta(null, 0);
                    if (Conta.Tipo == TipoDeConta.ContaPoupanca)
                    {
                        Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, TipoDeConta.ContaPoupanca);
                        Poupanca.Sacar(double.Parse(TxtValor.Text));
                        Salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, Poupanca);
                        opcoesDeConta = new OpcoesDeConta(Poupanca, 0);
                    }
                    else
                    {
                        Corrente.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, TipoDeConta.ContaCorrente);
                        Corrente.Sacar(double.Parse(TxtValor.Text));
                        Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, Corrente);
                        opcoesDeConta = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
                    }

                    Salvar.LerContas(TipoDeConta.ContaPoupanca);

                    foreach (ContaPoupanca conta in Salvar.LIstaDasPoupancas)
                    {
                        if (int.Parse(TxtAgencia.Text) == (int)conta.Agencia && int.Parse(TxtNumero.Text) == conta.Numero)
                        {
                            conta.Depositar(double.Parse(TxtValor.Text));
                            Salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, conta);
                            break;
                        }
                    }
                    if (Conta.Tipo == TipoDeConta.ContaPoupanca)
                    {
                        MessageBox.Show($"Seu saldo atual é de {Poupanca.Saldo.ToString("F2")}, Clique em OK para retornar a tela de opções",
                               "Deposito concluido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show($"Seu saldo atual é de {Corrente.Saldo.ToString("F2")}. Clique em OK para retornar a tela de opções",
                             "Deposito concluido",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.None);
                    }

                    opcoesDeConta.Show();
                    this.Dispose();

                }

                else if (RadioCorrente.Checked == true)
                {
                    OpcoesDeConta opcoesDeConta = new OpcoesDeConta(null, 0);

                    if (Conta.Tipo == TipoDeConta.ContaPoupanca)
                    {
                        Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, TipoDeConta.ContaPoupanca);
                        Poupanca.Sacar(double.Parse(TxtValor.Text));
                        Salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, Poupanca);
                        opcoesDeConta = new OpcoesDeConta(Poupanca, 0);
                    }
                    else
                    {
                        Corrente.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, TipoDeConta.ContaCorrente);
                        Corrente.Sacar(double.Parse(TxtValor.Text));
                        Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, Corrente);
                        opcoesDeConta = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
                    }

                    Salvar.LerContas(TipoDeConta.ContaCorrente);

                    foreach (ContaCorrente conta in Salvar.LIstaDasCorrentes)
                    {
                        if (int.Parse(TxtAgencia.Text) == (int)conta.Agencia && int.Parse(TxtNumero.Text) == conta.Numero)
                        {
                            conta.Depositar(double.Parse(TxtValor.Text));
                            Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, conta);
                            break;
                        }
                    }

                    if (Conta.Tipo == TipoDeConta.ContaPoupanca)
                    {
                        MessageBox.Show($"Seu saldo atual é de {Poupanca.Saldo.ToString("F2")}, Clique em OK para retornar a tela de opções",
                               "Deposito concluido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show($"Seu saldo atual é de {Corrente.Saldo.ToString("F2")}, Clique em OK para retornar a tela de opções",
                             "Deposito concluido",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.None);
                    }

                    opcoesDeConta.Show();
                    this.Dispose();
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
            if (Conta.Tipo == TipoDeConta.ContaPoupanca)
            {
                Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, TipoDeConta.ContaPoupanca);
                OpcoesDeConta opcoesDeConta = new OpcoesDeConta(Poupanca, 0);
                opcoesDeConta.Show();
                this.Visible = false;
            }
            else
            {
                Corrente.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, TipoDeConta.ContaCorrente);
                OpcoesDeConta opcoesDeConta = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
                opcoesDeConta.Show();
                this.Visible = false;
            }
        }

        private void TxtAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valorFinal = Validacao.ValidarNumeros(e, 1);

            TxtAgencia.Text = valorFinal;
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valorFinal = Validacao.ValidarNumeros(e, 1);

            TxtNumero.Text = valorFinal;
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

        private void TxtAgencia_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8 && e.KeyValue != 46)
            {
                TxtAgencia.Text = TxtAgencia.Text.Remove(0, 1);
            }
        }

        private void TxtNumero_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8 && e.KeyValue != 46)
            {
                TxtNumero.Text = TxtNumero.Text.Remove(0, 1);
            }
        }
    }
}
