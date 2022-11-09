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

        string digito;
        KeyPressEventArgs NumeroDeConta;
        KeyPressEventArgs NumeroDeAgencia;
        int ContadorDeagencia = 0;
        int ContadorDeConta = 0;

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
            NumeroDeAgencia = e;
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroDeConta = e;
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            digito = Validacao.ValidarNumerosParaValoresMonetarios(e);
        }

        private void TxtValor_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 40 || (int)e.KeyCode == 37 || (int)e.KeyCode == 39 || (int)e.KeyCode == 38) { digito = null; }
            TxtValor.Text = Validacao.Formatar(digito);
        }

        private void TxtAgencia_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 40 || (int)e.KeyCode == 37 || (int)e.KeyCode == 39 || (int)e.KeyCode == 38) { digito = null; }
            if ((int)e.KeyCode == 8 || (int)e.KeyCode == 46) { ContadorDeagencia--; } else { ContadorDeagencia++; }

            TxtAgencia.Text = Validacao.ValidarNumeros(NumeroDeAgencia);

            if (ContadorDeagencia == 1) { Validacao.LimpaLista(); }
        }

        private void TxtNumero_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 40 || (int)e.KeyCode == 37 || (int)e.KeyCode == 39 || (int)e.KeyCode == 38) { digito = null; }
            if ((int)e.KeyCode == 8 || (int)e.KeyCode == 46) { ContadorDeConta--; } else { ContadorDeConta++; }

            TxtNumero.Text = Validacao.ValidarNumeros(NumeroDeConta);

            if (ContadorDeConta == 4) { Validacao.LimpaLista(); }


        }
    }
}
