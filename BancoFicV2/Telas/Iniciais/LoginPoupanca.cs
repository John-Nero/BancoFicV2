using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class LoginPoupanca : Form
    {
        public LoginPoupanca()
        {
            InitializeComponent();
        }
        ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();

        KeyPressEventArgs NumeroDeConta;

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            SalvarELer Salvar = new SalvarELer();
            int confirmacao = 0;
            Salvar.LerContas(TipoDeConta.ContaPoupanca);
            foreach (ContaPoupanca conta in Salvar.LIstaDasPoupancas)
            {
                try
                {

                    if ((int)conta.Agencia == NumAgencia.Value && conta.Numero == int.Parse(TxtNumerodeconta.Text))
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
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message,
                            $"Desculpe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    TxtNumerodeconta.Focus();
                }
            }
            if (confirmacao == 0)
            {
                MessageBox.Show("Verifique se digitou corretamente os dados",
                             $"Agencia ou Numero de conta incorreto",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                TxtNumerodeconta.Focus();
            }

        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Opcoesiniciais opcoesiniciais = new Opcoesiniciais();
            opcoesiniciais.Show();
            this.Visible = false;
        }

        //Personalização do campo de texto
        private void txtNumerodeconta_Enter(object sender, EventArgs e) { TxtNumerodeconta.BackColor = Color.LightBlue; }

        private void txtNumerodeconta_Leave(object sender, EventArgs e) { TxtNumerodeconta.BackColor = Color.White; }

        //Validação de Caracter
        private void txtNumerodeconta_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroDeConta = e;
        }

        private void TxtNumerodeconta_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 40 || (int)e.KeyCode == 37 || (int)e.KeyCode == 39 || (int)e.KeyCode == 38) { NumeroDeConta = null; }

            TxtNumerodeconta.Text = Validacao.ValidarNumeros(NumeroDeConta);
        }
    }
}
