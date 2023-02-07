using BancoFicV2.Contas;
using BancoFicV2.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class LoginContas : Form
    {
        public LoginContas()
        {
            InitializeComponent();
        }
        ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            int confirmacao = 0;
            SalvarELer Salvar = new SalvarELer();

            try
            {
                if (RadioPoupanca.Checked)
                {
                    
                    Salvar.LerContas(TipoDeConta.ContaPoupanca);
                    foreach (ContaPoupanca conta in Salvar.LIstaDasPoupancas)
                    {
                        if ((int)conta.Agencia == NumAgencia.Value && conta.Numero == int.Parse(TxtNumeroDeConta.Text))
                        {
                            confirmacao++;
                            MessageBox.Show("Clique em OK para continuar",
                                       $"Seja Bem vindo {conta.Titular}",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.None);

                            conta.SetTipo(TipoDeConta.ContaPoupanca);
                            var opcoesdeconta = new OpcoesDeConta(conta, 0);
                            opcoesdeconta.Show();
                            this.Visible = false;
                            break;
                        }
                    }
                }

                if (RadioCorrente.Checked)
                {
                    
                    Salvar.LerContas(TipoDeConta.ContaCorrente);
                    if(TxtNumeroDeConta.Text == "") { TxtNumeroDeConta.Text = "0"; }
                    foreach (ContaCorrente conta in Salvar.LIstaDasCorrentes)
                    {
                        if ((int)conta.Agencia == NumAgencia.Value && conta.Numero == int.Parse(TxtNumeroDeConta.Text))
                        {
                            confirmacao++;
                            MessageBox.Show("Clique em OK para continuar",
                                       $"Seja Bem vindo {conta.Titular}",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.None);

                            conta.SetTipo(TipoDeConta.ContaCorrente);
                            var opcoesdeconta = new OpcoesDeConta(conta, conta.LimiteEmprestimo);
                            opcoesdeconta.Show();
                            this.Visible = false;
                            break;
                        }
                    }
                }

                if (RadioCorrente.Checked != true && RadioPoupanca.Checked != true)
                {
                    MessageBox.Show("Tipo de Conta não selecionado,por favor selecione um para prosseguir",
                                 $"Verifique se selecionou o tipo de conta",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                }
                else if (confirmacao == 0)
                {
                    MessageBox.Show("Verifique se digitou os dados corretamente",
                        "Dados incorretos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message,
                        $"Desculpe",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                TxtNumeroDeConta.Focus();
            }
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            var OpcoesIniciais = new OpcoesIniciais();
            OpcoesIniciais.Show();
            this.Visible = false;
        }

        private void TxtNumeroDeConta_Enter(object sender, EventArgs e) { TxtNumeroDeConta.BackColor = Color.LightBlue; }

        private void TxtNumeroDeConta_Leave(object sender, EventArgs e) { TxtNumeroDeConta.BackColor = Color.White; }

        private void TxtNumeroDeConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valorFinal = Validacao.ValidarNumeros(e, 1);
            TxtNumeroDeConta.Text = valorFinal;
        }

        private void TxtNumeroDeConta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8 && e.KeyValue != 46)
            {
                if (TxtNumeroDeConta.Text.Length != 0) { TxtNumeroDeConta.Text = TxtNumeroDeConta.Text.Remove(0, 1); }
            }
        }
    }
}