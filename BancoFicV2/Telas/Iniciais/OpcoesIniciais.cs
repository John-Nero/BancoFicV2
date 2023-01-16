using System;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class OpcoesIniciais : Form
    {
        public OpcoesIniciais()
        {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            var LoginContas = new LoginContas();
            LoginContas.Show();
            this.Visible = false;
        }

        private void BtCriarConta_Click(object sender, EventArgs e)
        {
            var CriarConta = new CriarConta();
            CriarConta.Show();
            this.Visible = false;
        }       
    }
}
