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

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            SalvarELer Salvar = new SalvarELer();
            int confirmacao = 0;
            Salvar.LerContas(TipoDeConta.ContaPoupanca);
            foreach (ContaPoupanca conta in Salvar.LIstaDasPoupancas)
            {
                try
                {
                    //(int)conta.Agencia == NumAgencia.Value && conta.Numero == int.Parse(TxtNumerodeconta.Text)

                    if (conta.Agencia == Agencias.Bahia && conta.Numero == 8378)
                    {
                        confirmacao++;
                        MessageBox.Show("Clique em OK para continuar",
                                   $"Seja Bem vindo {conta.Titular}",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.None);
                        conta.SetId(1);
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

        private void numAgencia_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void txtNumerodeconta_KeyPress(object sender, KeyPressEventArgs e)
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
            
        }


    }
}
