using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Saque : Form
    {
        Conta Conta;
        double Limite;
        string digito;
        string ValorTotalString;
        int ValorTotal = 0;
        List<int> NumerosDigitados = new List<int>();

        ContaCorrente Corrente = new ContaCorrente();
        ContaPoupanca Poupanca = new ContaPoupanca();
        SalvarELer Salvar = new SalvarELer();

        public Saque(Conta conta, double limite)
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
                    Poupanca.SetConta(Conta.Titular, Conta.Agencia, Conta.Numero, Conta.Cpf, Conta.Saldo, Conta.Id);
                    Poupanca.Sacar(double.Parse(TxtValor.Text));
                    Salvar.AtualizarDadosDeConta(TipoDeConta.ContaPoupanca, Poupanca);
                    MessageBox.Show($"Seu saldo atual é de {Poupanca.Saldo.ToString("F2")}, Clique em OK para retornar a tela de opções",
                           "Saque concluido",
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
                    Corrente.Sacar(double.Parse(TxtValor.Text));
                    Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, Corrente);
                    MessageBox.Show($"Seu saldo atual é de {Corrente.Saldo.ToString("F2")}, Clique em OK para retornar a tela de opções",
                               "Saque concluido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
                    Conta = null;
                    OpcoesDeConta opcoes = new OpcoesDeConta(Corrente, Limite);
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

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show($"o caracter {e.KeyChar.ToString().ToUpper()} não é permitido. Por favor digite apenas numeros",
                        "Digite apenas numeros",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else { digito = e.KeyChar.ToString(); }
        }

        private void formatar(string digito)
        {


            string CasaDecimail = "";
            string CasaCentenas = "";
            string CasaMilhar = "";

            int VerificadorDosCentavos = 0;
            int VerificadorDasCentenas = 0;

            string Centavos = "";
            string Centenas = "";
            string Milhar = "";

            foreach (int numero in NumerosDigitados)
            {
                ValorTotal += numero;
            }
            if (ValorTotal < 5000 && NumerosDigitados.Count != 6)
            {
                NumerosDigitados.Add(int.Parse(digito.ToString()));
            }
            else
            {
                MessageBox.Show($"O limite de saque On-Line é de 5.000,00(Cinco mil reais), para saques maiores visite uma agência",
                      "LIMITE DE SAQUE ULTRAPASADO",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                TxtValor.Text = ValorTotalString;
                goto avancoErro;
            }
            foreach (int numero in NumerosDigitados)
            {

                if (VerificadorDosCentavos < 2)
                {
                    CasaDecimail += numero.ToString();
                    VerificadorDosCentavos++;
                    Centavos = Convert.ToInt32(CasaDecimail).ToString(@"\,00");
                    TxtValor.Text = "00" + Centavos;
                    goto avancoFim;

                }

                if (VerificadorDosCentavos >= 2 && VerificadorDasCentenas < 3)
                {
                    CasaCentenas += numero.ToString();
                    VerificadorDasCentenas++;
                    Centenas = Convert.ToInt32(CasaCentenas).ToString(@"\.000");
                    TxtValor.Text = "0" + Centenas + Centavos;
                    goto avancoFim;

                }

                CasaMilhar += numero.ToString();
                Milhar = Convert.ToInt32(CasaMilhar).ToString("0");

                ValorTotalString = Milhar + Centenas + Centavos;
                ValorTotal = int.Parse(ValorTotalString.Replace(",", "").Replace(".", ""));

                TxtValor.Text = ValorTotalString;

            avancoFim:;
            }
        avancoErro:;
        }

        private void TxtValor_KeyUp(object sender, KeyEventArgs e)
        {
            formatar(digito);
        }
    }
}
