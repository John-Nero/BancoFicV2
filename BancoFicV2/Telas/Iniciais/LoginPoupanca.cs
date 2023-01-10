using System;
using System.Drawing;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class LoginPoupanca : Form
    {
        ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();

        public LoginPoupanca()
        {
            InitializeComponent();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            SalvarELer Salvar = new SalvarELer();
            int confirmacao = 0;


            Salvar.LerContas(TipoDeConta.ContaPoupanca);

            foreach (ContaPoupanca conta in Salvar.LIstaDasPoupancas)
            {
                try
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
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message,
                            $"Desculpe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    TxtNumeroDeConta.Focus();
                }
            }
            if (confirmacao == 0)
            {
                MessageBox.Show("Verifique se digitou corretamente os dados",
                             $"Agencia ou Numero de conta incorreto",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                TxtNumeroDeConta.Focus();
            }
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Login opcoesiniciais = new Login();
            opcoesiniciais.Show();
            this.Visible = false;
        }

        //Personalização do campo de texto
        private void txtNumerodeconta_Enter(object sender, EventArgs e) { TxtNumeroDeConta.BackColor = Color.LightBlue; }

        private void txtNumerodeconta_Leave(object sender, EventArgs e) { TxtNumeroDeConta.BackColor = Color.White; }

        private void txtNumerodeconta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valorFinal = Validacao.ValidarNumeros(e, 1);
            TxtNumeroDeConta.Text = valorFinal;
        }

        private void TxtNumerodeconta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8 && e.KeyValue != 46)
            {
                if (TxtNumeroDeConta.Text.Length != 0) { TxtNumeroDeConta.Text = TxtNumeroDeConta.Text.Remove(0, 1); }
            }
        }
    }

}
